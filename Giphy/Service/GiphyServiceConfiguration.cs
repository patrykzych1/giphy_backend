namespace Giphy.Service
{
    public class GiphyServiceConfiguration
    {
        public readonly string ApiKey;

        public GiphyServiceConfiguration(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}