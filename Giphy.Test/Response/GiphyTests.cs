using FluentAssertions;
using Giphy.Dto;
using Giphy.Response;

namespace Giphy.Test.Response
{
    public class GiphyTests
    {
        [Fact]
        public void Should_convert_to_dto()
        {
            // Arrange 
            var giphy = new Giphy.Response.Giphy()
            {
                Id = "1",
                Rating = "g",
                Images = new Images
                {
                    Original = new Original
                    {
                        Url = "url"
                    }
                }
            };
            var expectedResult = new GiphyDto()
            {
                Id = "1",
                Rating = "g",
                Url = "url"
            };

            // Act
            var dto = giphy.ToDto();

            // Assert
            dto.Should().BeEquivalentTo(expectedResult);
        }
    }
}
