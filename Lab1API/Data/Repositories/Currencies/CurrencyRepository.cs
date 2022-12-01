using Lab1API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Currencies
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CurrencyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Сurrency>> GetAllCategories()
        {
            return await _dbContext.Currencies.ToListAsync();
        }
    }
}
