using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAwayProject.Application.Features.CQRS.Commands.OrderDetailCommands
{
    public class RemoveOrderDetailCommand
    {
        public RemoveOrderDetailCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
