using Lab1API.Models;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Users
{
    public interface IUserRepository
    {
        Task<int> AddUserAsync(User user);
        Task ChangeUserDefaultСurrencyAsunc(int userId, int currencyId);
        Task<int> GetUserDefaultСurrencyAsunc(int userId);
    }
}
