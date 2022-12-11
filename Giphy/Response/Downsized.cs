using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Downsized : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
