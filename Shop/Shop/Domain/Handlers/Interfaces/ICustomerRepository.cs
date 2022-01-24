using Shop.Domain.Entities;
using Shop.Domain.Queries.Responses;
using System;

namespace Shop.Domain.Handlers.Interfaces
{
    public interface ICustomerRepository
    {
        public void Save(Customer customer);
        public FindCustomerByIdResponse GetCustomerById(Guid id);
    }
}
