using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class FixedWidthDownsampled : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
        [JsonPropertyName("webp_size")]
        public string? WebpSize { get; set; }
        [JsonPropertyName("webp")]
        public string? Webp { get; set; }
    }
}
