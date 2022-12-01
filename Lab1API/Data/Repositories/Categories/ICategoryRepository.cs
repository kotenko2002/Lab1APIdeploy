using Lab1API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task<int> AddCategoryAsync(Category category);
        Task<IEnumerable<Category>> GetAllCategories();
    }
}
