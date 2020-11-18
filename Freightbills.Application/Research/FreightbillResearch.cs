using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Freightbills.Domain;
using Freightbills.Repository;
using MediatR;

namespace Freightbills.Application.Research
{
    public class FreightbillResearch
    {
            public class Query : IRequest<IEnumerable<FreightBill>>
            {
                private readonly string _query = "SELECT * FROM Freightbills";
            
                public override string ToString()
                {
                    return _query;
                }
            }

            public class Handler : IRequestHandler<Query, IEnumerable<FreightBill>>
            {
                private readonly SqlRepository _repository;

                public Handler(SqlRepository repository)
                {
                    _repository = repository;
                }

                public async Task<IEnumerable<FreightBill>> Handle(Query request, CancellationToken cancellationToken)
                {
                    var freightbills = await _repository.GetListAsync<FreightBill>(request.ToString());
                    return freightbills;
                }
            }
    }
}