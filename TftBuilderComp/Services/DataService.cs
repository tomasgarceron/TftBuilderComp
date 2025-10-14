using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using TftComp.Models;

namespace TftComp.Services
{
    public class DataService
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public DataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Champion>> GetChampionsAsync()
        {
            // lee desde wwwroot/data/champions.json
            return await _http.GetFromJsonAsync<List<Champion>>("data/champions.json", _options)
                   ?? new List<Champion>();
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await _http.GetFromJsonAsync<List<Item>>("data/items.json", _options)
                   ?? new List<Item>();
        }

        public async Task<List<Composition>> GetCompsAsync()
        {
            return await _http.GetFromJsonAsync<List<Composition>>("data/comps.json", _options)
                   ?? new List<Composition>();
        }

        // Si por alguna razón necesitás obtener el texto raw:
        public async Task<string> GetRawJsonAsync(string relativePath)
        {
            // relativePath ejemplo: "data/champions.json"
            return await _http.GetStringAsync(relativePath);
        }
    }
}
