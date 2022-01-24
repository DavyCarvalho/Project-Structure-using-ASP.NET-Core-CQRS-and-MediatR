namespace Shop.Domain.Handlers.Interfaces
{
    public interface IEmailService
    {
        public void Send(string name, string email);
    }
}
