using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class FixedHeightStill : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
