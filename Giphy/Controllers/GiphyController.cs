using Giphy.Request;
using Giphy.Service;
using Microsoft.AspNetCore.Mvc;

namespace Giphy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiphyController : ControllerBase
    {
        private readonly IGiphyService _service;
        private readonly ILogger<GiphyController> _logger;
        public GiphyController(IGiphyService service, ILogger<GiphyController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GiphySearchRequest giphySearchRequest)
        {
            try
            {
                var result = await _service.GetAsync(giphySearchRequest);
                var res = result?.Data?.Select(x => x.ToDto()).ToList();
                return Ok(res);
            }
            catch (Exception? ex)
            {
                _logger.LogError(ex, "Error while fetching giphies");
                return BadRequest(ex.Message);
            }
        }
    }
}
