using LoginAspNetCore.Models;

namespace LoginAspNetCore.Repository.Contract
{
    public interface IManagerRepository
    {
        Manager Login(string username, string password);
        void Register(Manager manager);
        void Update(Manager manager);
        void Delete(int id);
        Manager Select(int id);

    }
}
