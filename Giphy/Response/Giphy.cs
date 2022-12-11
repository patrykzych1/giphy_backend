﻿using Giphy.Dto;
using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Giphy
    {

        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        [JsonPropertyName("bitly_gif_url")]
        public string? BitlyGifUrl { get; set; }
        [JsonPropertyName("bitly_url")]
        public string? BitlyUrl { get; set; }
        [JsonPropertyName("embed_url")]
        public string? EmbedUrl { get; set; }
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("rating")]
        public string? Rating { get; set; }
        [JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }
        [JsonPropertyName("source_tld")]
        public string? SourceTld { get; set; }
        [JsonPropertyName("source_post_url")]
        public string? SourcePostUrl { get; set; }
        [JsonPropertyName("is_sticker")]
        public int? IsSticker { get; set; }
        [JsonPropertyName("import_datetime")]
        public string? ImportDatetime { get; set; }
        [JsonPropertyName("trending_datetime")]
        public string? TrendingDatetime { get; set; }
        [JsonPropertyName("images")]
        public Images? Images { get; set; }
        [JsonPropertyName("user")]
        public User? User { get; set; }
        [JsonPropertyName("analytics_response_payload")]
        public string? AnalyticsResponsePayload { get; set; }
        [JsonPropertyName("analytics")]
        public Analytics? Analytics { get; set; }

        public GiphyDto ToDto()
        {
            return new GiphyDto
            {
                Id = Id,
                Rating = Rating,
                Url = Images?.Original?.Url
            };
        }
    }

}
