using System.Collections.Specialized;

namespace Giphy.Request
{
    public class GiphySearchRequest
    {
        public string? Lang { get; set; }
        public string? Rating { get; set; }
        public string? Offset { get; set; }
        public string? Q { get; set; }
        public string? Limit { get; set; }

        public string? ToQueryString()
        {
            NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);
            query.Add("q", Q);
            query.Add("rating", Rating);
            query.Add("lang", Lang);
            query.Add("limit", Limit);
            query.Add("offset", Offset);
            return query.ToString();
        }
    }
}
