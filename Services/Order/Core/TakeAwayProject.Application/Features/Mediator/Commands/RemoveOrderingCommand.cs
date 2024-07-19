using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAwayProject.Application.Features.Mediator.Commands
{
    public class RemoveOrderingCommand : IRequest
    {
        public RemoveOrderingCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
