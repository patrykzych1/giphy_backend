using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class WStill : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
