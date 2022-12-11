using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Onload
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}