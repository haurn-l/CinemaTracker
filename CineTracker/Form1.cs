using CineTracker.Database;
using CineTracker.Models;
using CineTracker.Services; 
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CineTracker
{
    public partial class Form1 : Form
    {
        // Services
        private readonly MovieService _movieService = new MovieService();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            await Top10DoldurAsync();
            await EditorSecimleriniDoldurAsync();
        }

        private async Task Top10DoldurAsync()
        {
            string dosyaYolu = "top10.txt"; // Txt dosyamızın adı
            List<string> top10Ids = new List<string>();

            if (File.Exists(dosyaYolu))
            {
                top10Ids = new List<string>(File.ReadAllLines(dosyaYolu));
            }
            else
            {
                MessageBox.Show("top10.txt dosyası bulunamadı! Lütfen programın yanına ekleyin.", "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (string id in top10Ids)
            {
                MovieDetail movie = await _movieService.GetMovieByIdAsync(id);

                if (movie != null && movie.Response != "False")
                {
                    dgvTop10.Rows.Add(movie.Title, movie.Year, "⭐ " + movie.ImdbRating);
                }
            }
        }
        private async Task EditorSecimleriniDoldurAsync()
        {
            dgvEditor.Rows.Clear(); // Önce tabloyu temizle (aynı filmler alt alta yığılmasın)
            List<string> favoriIdler = new List<string>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                // Son eklenen en üstte çıksın diye DESC yaptık
                string query = "SELECT imdb_id FROM editor_secimleri ORDER BY eklenme_tarihi DESC";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        favoriIdler.Add(reader.GetString("imdb_id"));
                    }
                }
            }

            // Çektiğimiz ID'leri OMDb API'ye sorup tabloya basıyoruz
            foreach (string id in favoriIdler)
            {
                MovieDetail movie = await _movieService.GetMovieByIdAsync(id);
                if (movie != null && movie.Response != "False")
                {
                    dgvEditor.Rows.Add(movie.Title, movie.Year, "⭐ " + movie.ImdbRating);
                }
            }
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFilmArama.Text))
            {
                Form2 detayFormu = new Form2(txtFilmArama.Text);

                this.Hide();
                detayFormu.ShowDialog();
                this.Show();

                //Form2 kapanıp Form1 uyanınca hemen tabloyu yenile!
                await EditorSecimleriniDoldurAsync();

                txtFilmArama.Clear();
            }
        }
        private async void dgvTop10_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string secilenFilm = dgvTop10.Rows[e.RowIndex].Cells[0].Value.ToString();
                Form2 detayFormu = new Form2(secilenFilm);

                this.Hide();
                detayFormu.ShowDialog();
                this.Show();

                // Form2 kapanınca hemen tabloyu yenile!
                await EditorSecimleriniDoldurAsync();
            }
        }

        private async void dgvEditor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string secilenFilm = dgvEditor.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Form2'ye fırlat
                Form2 detayFormu = new Form2(secilenFilm);

                this.Hide(); // 1. Form1'i gizle
                detayFormu.ShowDialog(); // 2. Form2'yi aç ve bekle
                this.Show(); // 3. Form2 kapanınca uyan!

          
                await EditorSecimleriniDoldurAsync();
            }
        }
    }
}