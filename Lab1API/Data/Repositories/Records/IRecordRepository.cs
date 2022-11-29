using Lab1API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Records
{
    public interface IRecordRepository
    {
        Task AddRecordAsync(Record record);
        Task<Record> GetRecordById(int id);
        Task<IEnumerable<Record>> GetRecordsByUserIdAndCategoryId (int userId, int categoryId);
    }
}
