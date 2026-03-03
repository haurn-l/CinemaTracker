using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CineTracker.Database
{
    public class DatabaseHelper
    {
       
        private static string connectionString = "Server=localhost;Database=sinevazyon_db;Uid=root;Pwd=YOUR_PASSWORD!;";

        // Her veritabanı işlemi gerektiğinde bu metodu çağırıp kapıyı açacağız
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı! MySQL açık mı kontrol et.\nHata: " + ex.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
