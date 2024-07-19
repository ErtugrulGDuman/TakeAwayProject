using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeAwayProject.Application.Features.CQRS.Queries.OrderDetailQueries;
using TakeAwayProject.Application.Features.CQRS.Results.OrderDetailResults;
using TakeAwayProject.Application.Interfaces;
using TakeAwayProject.Domain.Entities;

namespace TakeAwayProject.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdOueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdOueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetOrderDetailByIdQueryResult
            {
                Amount = values.Amount,
                OrderDetailId = values.OrderDetailId,
                OrderingId = values.OrderingId,
                Price = values.Price,
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                TotalPrice = values.TotalPrice
            };
        }
    }
}
