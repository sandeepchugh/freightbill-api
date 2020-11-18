using System.Collections.Generic;
using System.Threading.Tasks;
using Freightbills.Application.Research;
using Freightbills.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Freightbills.Api.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class FreightbillsController : ControllerBase
    {
        private readonly ILogger<FreightbillsController> _logger;
        private readonly IMediator _mediator;
        
        public FreightbillsController(IMediator mediator,ILogger<FreightbillsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<FreightBill>> Get()
        {
            return await _mediator.Send(new FreightbillResearch.Query());
        }
    }
}