using System.Collections.Generic;
using System.Threading.Tasks;
using Freightbills.Application.Payments;
using Freightbills.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Freightbills.Api.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        private readonly ILogger<PaymentsController> _logger;

        public PaymentsController(IMediator mediator,ILogger<PaymentsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        
        [HttpGet]
        public async Task<IEnumerable<Payment>> Get()
        {
            return await _mediator.Send(new LastPayments.Query());
        }
    }
}