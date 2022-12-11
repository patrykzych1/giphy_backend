using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class GiphySearchResponse
    {
        [JsonPropertyName("data")]
        public Giphy[]? Data { get; set; }
        [JsonPropertyName("pagination")]
        public Pagination? Pagination { get; set; }
        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }
    }
}
