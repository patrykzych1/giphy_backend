﻿using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Pagination
    {
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        [JsonPropertyName("offset")]
        public int? Offset { get; set; }
    }
}
