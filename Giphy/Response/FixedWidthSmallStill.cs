using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class FixedWidthSmallStill : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
