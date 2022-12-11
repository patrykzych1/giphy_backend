using Giphy.Request;
using Giphy.Response;

namespace Giphy.Service
{
    public interface IGiphyService
    {
        Task<GiphySearchResponse?> GetAsync(GiphySearchRequest request);
    }
}
