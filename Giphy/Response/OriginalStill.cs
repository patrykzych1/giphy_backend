using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class OriginalStill : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
