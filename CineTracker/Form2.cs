using CineTracker.Database;
using CineTracker.Models;
using CineTracker.Services;
using MySql.Data.MySqlClient; 
using System;
using System.Windows.Forms;
namespace CineTracker
{
    public partial class Form2 : Form
    {
        private string _arananFilmAdi;
        private MovieService _movieService = new MovieService();
        private MovieDetail _suankiFilm; // Veritabanı işlemleri için filmi hafızada tutacağız
        private bool _isFavori = false; // Filmin veritabanında olup olmadığını tutacağız
        // api ile film adı alacağız
        public Form2(string filmAdi)
        {
            InitializeComponent();
            _arananFilmAdi = filmAdi;
        }
        private void FavoriDurumunuKontrolEt()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                string query = "SELECT COUNT(*) FROM editor_secimleri WHERE imdb_id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _suankiFilm.ImdbId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    _isFavori = (count > 0); // Eğer count 0'dan büyükse film bizdedir!
                }
            }
            YildizIkonunuGuncelle();
        }

      
        private void YildizIkonunuGuncelle()
        {
            if (_isFavori)
            {
                btnYildiz.Text = "★ Favorilerden Çıkar";
                btnYildiz.ForeColor = Color.Gold; // İçi dolu sarı yıldız
            }
            else
            {
                btnYildiz.Text = "☆ Favoriye Ekle";
                btnYildiz.ForeColor = Color.White; // İçi boş beyaz yıldız
            }
        }

    // INSERT - DELETE
        private void btnYildiz_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                if (_isFavori)
                {
                    // Zaten favoriyse, veritabanından SİL
                    string query = "DELETE FROM editor_secimleri WHERE imdb_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _suankiFilm.ImdbId);
                        cmd.ExecuteNonQuery();
                    }
                    _isFavori = false;
                }
                else
                {
                    // Favori değilse, veritabanına EKLE
                    string query = "INSERT INTO editor_secimleri (imdb_id, film_adi, poster_url) VALUES (@id, @adi, @poster)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _suankiFilm.ImdbId);
                        cmd.Parameters.AddWithValue("@adi", _suankiFilm.Title);
                        cmd.Parameters.AddWithValue("@poster", _suankiFilm.Poster);
                        cmd.ExecuteNonQuery();
                    }
                    _isFavori = true;
                }
            }
            YildizIkonunuGuncelle(); // Butonun görselini yenile
        }

        // 1. FORM AÇILDIĞINDA FİLMİ ÇEK VE EKRANA BAS
        private async void Form2_Load(object sender, EventArgs e)
        {
            _suankiFilm = await _movieService.GetMovieByTitleAsync(_arananFilmAdi);

            if (_suankiFilm != null && _suankiFilm.Response != "False")
            {
                lblFilmAdi.Text = _suankiFilm.Title;
                lblOzet.Text = "Yıl: " + _suankiFilm.Year + "\nTür: " + _suankiFilm.Genre + "\n\n" + _suankiFilm.Plot;

                if (_suankiFilm.Poster != "N/A")
                {
                    picPoster.LoadAsync(_suankiFilm.Poster);
                }

                // İŞTE EKSİK OLAN HAYAT KURTARICI SATIR BURASI! 
                // Film API'den gelip ekrana basıldıktan HEMEN SONRA veritabanına bakmalı:
                FavoriDurumunuKontrolEt();
            }
            else
            {
                MessageBox.Show("Film bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close(); // Form2'yi kapatır, alttaki Form1 zaten açık kalmıştı
        }

        
    }
}