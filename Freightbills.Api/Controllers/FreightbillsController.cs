using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Freightbills.Api.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FreightbillsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FreightbillsController> _logger;

        public FreightbillsController(ILogger<FreightbillsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var weatherList = new List<string>(){"warm"};
            return weatherList;
        }
    }
}