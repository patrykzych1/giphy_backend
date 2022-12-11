using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Meta
    {
        [JsonPropertyName("status")]
        public int? Status { get; set; }
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }
        [JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }
    }
}
