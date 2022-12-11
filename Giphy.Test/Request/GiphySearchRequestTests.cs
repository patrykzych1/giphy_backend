using FluentAssertions;
using Giphy.Request;

namespace Giphy.Test.Request
{
    public class GiphySearchRequestTests
    {
        [Fact]
        public void Should_convert_to_query_string()
        {
            // Arrange
            var request = new GiphySearchRequest()
            {
                Rating = "g",
                Q = "happy birthsday",
                Limit = "25",
                Offset = "0"
            };

            // Act
            var result = request.ToQueryString();

            // Assert
            result.Should().BeEquivalentTo("q=happy+birthsday&rating=g&limit=25&offset=0");
        }        
    }
}
