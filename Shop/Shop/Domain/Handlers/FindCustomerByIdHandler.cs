using MediatR;
using Shop.Domain.Handlers.Interfaces;
using Shop.Domain.Queries.Requests;
using Shop.Domain.Queries.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        private readonly ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            var result =  _repository.GetCustomerById(request.Id);
            return Task.FromResult(result);
        }
    }
}
