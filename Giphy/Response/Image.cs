using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Image
    {
        [JsonPropertyName("height")]
        public string? Height { get; set; }
        [JsonPropertyName("width")]
        public string? Width { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
