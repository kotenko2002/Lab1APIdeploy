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

        public async Task SecretRequestAsync()
        {
            _dbContext.Currencies.Add(new Сurrency() { Name = "UAH" });
            _dbContext.Currencies.Add(new Сurrency() { Name = "USD" });
            _dbContext.Currencies.Add(new Сurrency() { Name = "EUR" });

            await _dbContext.SaveChangesAsync();
        }
    }
}
