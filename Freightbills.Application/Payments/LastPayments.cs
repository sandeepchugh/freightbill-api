using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Freightbills.Domain;
using Freightbills.Repository;
using MediatR;

namespace Freightbills.Application.Payments
{
    public class LastPayments
    {
        public class Query : IRequest<IEnumerable<Payment>>
        {
            private readonly string _query = "SELECT * FROM LastPayments";
            
            public override string ToString()
            {
                return _query;
            }
        }

        public class Handler : IRequestHandler<Query, IEnumerable<Payment>>
        {
            private readonly SqlRepository _repository;

            public Handler(SqlRepository repository)
            {
                _repository = repository;
            }

            public async Task<IEnumerable<Payment>> Handle(Query request, CancellationToken cancellationToken)
            {
                var payments = await _repository.GetListAsync<Payment>(request.ToString());
                return payments;
            }
        }
    }
}