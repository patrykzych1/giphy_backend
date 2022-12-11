using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Looping
    {
        [JsonPropertyName("mp4_size")]
        public string? Mp4Size { get; set; }
        [JsonPropertyName("mp4")]
        public string? Mp4 { get; set; }
    }
}
