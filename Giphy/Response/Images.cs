using System.Text.Json.Serialization;

namespace Giphy.Response
{
    public class Images
    {
        [JsonPropertyName("original")]
        public Original? Original { get; set; }
        [JsonPropertyName("downsized")]
        public Downsized? Downsized { get; set; }
        [JsonPropertyName("downsized_large")]
        public DownsizedLarge? DownsizedLarge { get; set; }
        [JsonPropertyName("downsized_medium")]
        public DownsizedMedium? DownsizedMedium { get; set; }
        [JsonPropertyName("downsized_small")]
        public DownsizedSmall? DownsizedSmall { get; set; }
        [JsonPropertyName("downsized_still")]
        public DownsizedStill? DownsizedStill { get; set; }
        [JsonPropertyName("fixed_height")]
        public FixedHeight? FixedHeight { get; set; }
        [JsonPropertyName("fixed_height_downsampled")]
        public FixedHeightDownsampled? FixedHeightDownsampled { get; set; }
        [JsonPropertyName("fixed_height_small")]
        public FixedHeightSmall? FixedHeightSmall { get; set; }
        [JsonPropertyName("fixed_height_small_still")]
        public FixedHeightSmallStill? FixedHeightSmallStill { get; set; }
        [JsonPropertyName("fixed_height_still")]
        public FixedHeightStill? FixedHeightStill { get; set; }
        [JsonPropertyName("fixed_width")]
        public FixedWidth? FixedWidth { get; set; }
        [JsonPropertyName("fixed_width_downsampled")]
        public FixedWidthDownsampled? FixedWidthDownsampled { get; set; }
        [JsonPropertyName("fixed_width_small")]
        public FixedWidthSmall? FixedWidthSmall { get; set; }
        [JsonPropertyName("fixed_width_small_still")]
        public FixedWidthSmallStill? FixedWidthSmallStill { get; set; }
        [JsonPropertyName("fixed_width_still")]
        public FixedWidthStill? FixedWidthStill { get; set; }
        [JsonPropertyName("looping")]
        public Looping? Looping { get; set; }
        [JsonPropertyName("original_still")]
        public OriginalStill? OriginalStill { get; set; }
        [JsonPropertyName("original_mp4")]
        public OriginalMp4? OriginalMp4 { get; set; }
        [JsonPropertyName("preview")]
        public Preview? Preview { get; set; }
        [JsonPropertyName("preview_gif")]
        public PreviewGif? PreviewGif { get; set; }
        [JsonPropertyName("480w_still")]
        public WStill? WStill { get; set; }

    }
}
