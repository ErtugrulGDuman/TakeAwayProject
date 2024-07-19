using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayProject.Application.Features.CQRS.Results.OrderDetailResults;
using TakeAwayProject.Application.Interfaces;
using TakeAwayProject.Domain.Entities;

namespace TakeAwayProject.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailOueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailOueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetOrderDetailQueryResult
            {
                Amount = x.Amount,
                OrderDetailId = x.OrderDetailId,
                OrderingId = x.OrderingId,
                Price = x.Price,
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                TotalPrice = x.TotalPrice
            }).ToList();
        }
    }
}
