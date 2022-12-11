using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Preview : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
