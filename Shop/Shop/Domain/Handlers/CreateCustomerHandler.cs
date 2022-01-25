using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Entities;
using Shop.Domain.Handlers.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        private readonly ICustomerRepository _repository;
        private readonly IEmailService _emailService;

        public CreateCustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Cria a entidade
            var customer = new Customer(request.Name, request.Email);

            // Persiste a entidade no banco
            _repository.Save(customer);

            // Envia E-mail de boas-vindas
            _emailService.Send(customer.Name, customer.Email);

            // Retorna a resposta
            var result = new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
