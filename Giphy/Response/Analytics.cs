using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Analytics
    {
        [JsonPropertyName("onload")]
        public Onload? Onload { get; set; }
        [JsonPropertyName("onclick")]
        public Onclick? Onclick { get; set; }
        [JsonPropertyName("onsent")]
        public Onsent? Onsent { get; set; }
    }
}
