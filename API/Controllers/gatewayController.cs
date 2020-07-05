using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        private readonly IInfoService _infoService;

        public GatewayController(IInfoService infoService)
        {
            _infoService = infoService;
        }


        [HttpGet("{value}")]
        public IActionResult Get(string value)
        {
            var info = _infoService.GetInfo(value);
            return Ok(info);
        }
    }
}
