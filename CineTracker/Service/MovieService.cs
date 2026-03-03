using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CineTracker.Models; // DTO'muz

namespace CineTracker.Services
{
    public class MovieService
    {
        // İnternet isteklerini atacağımız ağır abimiz
        private readonly HttpClient _httpClient;

        // API KEY(Örn: ("8a1b2c3d")
        private readonly string _apiKey = "432a6c45";

        public MovieService()
        {
            _httpClient = new HttpClient();
        }

        // Arama çubuğundan Film Adı (Title) ile arama yapmak için
        public async Task<MovieDetail> GetMovieByTitleAsync(string title)
        {
            // OMDb API'de isme göre arama yaparken '?t=' parametresi kullanılır
            string url = $"https://www.omdbapi.com/?t={title}&apikey={_apiKey}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Hata varsa (404, 500) direkt catch'e düşürür

                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Gelen karmaşık JSON'ı bizim o jilet gibi MovieDetail DTO'suna çeviriyoruz
                return JsonSerializer.Deserialize<MovieDetail>(jsonResponse);
            }
            catch (Exception)
            {
                // İnternet koparsa veya API çökerse program patlamasın diye null dönüyoruz
                return null;
            }
        }

        // Top 10 listesini doldururken IMDb ID'si (Örn: tt0111161) ile arama yapmak için
        public async Task<MovieDetail> GetMovieByIdAsync(string imdbId)
        {
            // OMDb API'de ID'ye göre arama yaparken '?i=' parametresi kullanılır
            string url = $"https://www.omdbapi.com/?i={imdbId}&apikey={_apiKey}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<MovieDetail>(jsonResponse);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}