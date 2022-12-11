using FluentAssertions;
using Giphy.Controllers;
using Giphy.Request;
using Giphy.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace Giphy.Test.Controllers
{
    public class GiphyControllerTests
    {
        [Fact]
        public async Task Should_log_exception_and_return_bad_request()
        {
            // Arrange
            var giphyService = new Mock<IGiphyService>();
            var logger = new Mock<ILogger<GiphyController>>();

            var controller = new GiphyController(giphyService.Object, logger.Object);
            var exceptionMessage = "exceptionMessage";
            var exception = new Exception(exceptionMessage);
            var request = new GiphySearchRequest()
            {
                Lang = "en",
                Q = "Happy birthsday"
            };
            giphyService.Setup(x => x.GetAsync(It.IsAny<GiphySearchRequest>())).Throws(exception);

            // Act
            var result = await controller.Get(request);

            // Assert
            logger.Verify(x => x.Log(
                It.IsAny<LogLevel>(),
                It.IsAny<EventId>(),
                It.Is<It.IsAnyType>((@object, @type) => @object.ToString() == "Error while fetching giphies" && @type.Name == "FormattedLogValues"),
                It.Is<Exception>(ex => ex == exception),
                (Func<It.IsAnyType, Exception, string>)It.IsAny<object>()));
            result.Should().BeEquivalentTo(new BadRequestObjectResult(exception.Message));

        }
    }
}
