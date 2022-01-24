using Shop.Domain.Handlers.Interfaces;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;

namespace Shop.Domain.Handlers
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        private readonly ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest command)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            return _repository.GetCustomerById(command.Id);
        }
    }
}
