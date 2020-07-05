using Microsoft.AspNetCore.Mvc;
using PhantomBot;
//using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : ControllerBase
    {
        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IPhantom _phantom;

        public GatewayController(IPhantom phantom)
        {
            _phantom = phantom;
        }

        [HttpGet("{value}")]
        public IActionResult Get(string value)
        {
            var info = _phantom.GetInfo(value);
            return Ok(info);
        }
    }
}
