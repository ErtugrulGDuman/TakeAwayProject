using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayProject.Application.Features.Mediator.Commands;
using TakeAwayProject.Application.Interfaces;
using TakeAwayProject.Domain.Entities;

namespace TakeAwayProject.Application.Features.Mediator.Handlers
{
    public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;
        public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveOrderingCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
