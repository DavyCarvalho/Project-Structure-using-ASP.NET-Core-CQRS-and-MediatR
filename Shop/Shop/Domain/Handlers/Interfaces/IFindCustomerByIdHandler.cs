using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;

namespace Shop.Domain.Handlers
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);
    }
}
