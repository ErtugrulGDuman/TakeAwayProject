using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayProject.Application.Features.Mediator.Results;

namespace TakeAwayProject.Application.Features.Mediator.Queries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}
