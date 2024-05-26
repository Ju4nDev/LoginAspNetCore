using LoginAspNetCore.Models;

namespace LoginAspNetCore.Repository.Contract
{
    public interface IClientRepository
    {
        Client Login(string username, string password);
        void Register(Client client);
        void Update(Client client);
        void Delete(int id);
        Client Select(int id);
    }
}
