using Lab1API.Models;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Users
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
    }
}
