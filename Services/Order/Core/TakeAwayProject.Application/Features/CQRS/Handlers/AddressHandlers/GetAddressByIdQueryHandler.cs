using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAwayProject.Application.Features.CQRS.Queries.AddressQueries;
using TakeAwayProject.Application.Features.CQRS.Results.AddressResults;
using TakeAwayProject.Application.Interfaces;
using TakeAwayProject.Domain.Entities;

namespace TakeAwayProject.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAddressByIdQueryResult
            {
                AddressId = query.Id,
                City = values.City,
                Detail = values.Detail,
                District = values.District,
                Name = values.Name,
                UserId = values.UserId
            };
        }
    }
}
