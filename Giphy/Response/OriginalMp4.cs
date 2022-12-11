using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class OriginalMp4 : Image
    {
        [JsonPropertyName("size")]
        public string? Size { get; set; }
    }
}
