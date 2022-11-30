using Lab1API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Currencies
{
    public class СurrencyRepository : IСurrencyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public СurrencyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Сurrency>> GetAllCategories()
        {
            return await _dbContext.Currencies.ToListAsync();
        }
    }
}
