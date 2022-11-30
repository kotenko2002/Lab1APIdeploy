using Lab1API.Models;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddUserAsync(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task ChangeUserDefaultСurrencyAsunc(int userId, int currencyId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user == null)
            {
                throw new System.Exception("No user with such Id");
            }

            user.СurrencyId = currencyId;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> GetUserDefaultСurrencyAsunc(int userId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if(user == null)
            {
                throw new System.Exception("No user with such Id");
            }

            return user.СurrencyId;
        }
    }
}
