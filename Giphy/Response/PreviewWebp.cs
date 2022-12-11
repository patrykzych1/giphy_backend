using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class PreviewWebp : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
