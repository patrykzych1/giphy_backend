using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class FixedHeightSmallStill : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
