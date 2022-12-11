using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class FixedHeight : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
        [JsonPropertyName("mp4_size")]
        public string? Mp4Size { get; set; }
        [JsonPropertyName("mp4")]
        public string? Mp4 { get; set; }
        [JsonPropertyName("webp_size")]
        public string? WebpSize { get; set; }
        [JsonPropertyName("webp")]
        public string? Webp { get; set; }
    }
}
