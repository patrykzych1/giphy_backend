using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class PreviewGif : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
