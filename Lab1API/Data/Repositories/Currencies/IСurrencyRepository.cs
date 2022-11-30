using Lab1API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Currencies
{
    public interface IСurrencyRepository
    {
        Task<IEnumerable<Сurrency>> GetAllCategories();
    }
}
