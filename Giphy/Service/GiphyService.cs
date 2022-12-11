using Giphy.Request;
using Giphy.Response;
using System.Text.Json;

namespace Giphy.Service
{
    public class GiphyService : IGiphyService
    {
        private readonly HttpClient _httpClient;
        private readonly GiphyServiceConfiguration _configuration;

        public GiphyService(HttpClient httpClient, GiphyServiceConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<GiphySearchResponse?> GetAsync(GiphySearchRequest request)
        {
            try
            {
                var response = await _httpClient.GetAsync("search?api_key=" + _configuration.ApiKey + "&" + request.ToQueryString());
                var responseText = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<GiphySearchResponse>(responseText);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"{_httpClient.BaseAddress}search: {result?.Meta?.Status} - {result?.Meta?.Msg}");
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
