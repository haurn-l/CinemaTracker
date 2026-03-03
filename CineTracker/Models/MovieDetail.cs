using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CineTracker.Models
{
    public class MovieDetail
    {
        // Film ID (Örn: tt0111161)
        [JsonPropertyName("imdbID")]
        public string ImdbId { get; set; }

        // Filmin Adı
        [JsonPropertyName("Title")]
        public string Title { get; set; }

        // Çıkış Yılı
        [JsonPropertyName("Year")]
        public string Year { get; set; }

        // Tür
        [JsonPropertyName("Genre")]
        public string Genre { get; set; }

        // Filmin Özeti
        [JsonPropertyName("Plot")]
        public string Plot { get; set; }

        // Afişin internet adresi (Form2'de PictureBox)
        [JsonPropertyName("Poster")]
        public string Poster { get; set; }

        // IMDb Puanı
        [JsonPropertyName("imdbRating")]
        public string ImdbRating { get; set; }

        // Bazen film bulunamazsa API "Response": "False" döner, onu yakalamak için
        [JsonPropertyName("Response")]
        public string Response { get; set; }
    }
}