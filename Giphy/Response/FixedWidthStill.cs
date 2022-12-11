using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class FixedWidthStill : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
