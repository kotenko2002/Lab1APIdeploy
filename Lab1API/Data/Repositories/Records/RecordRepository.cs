using Lab1API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1API.Data.Repositories.Records
{
    public class RecordRepository : IRecordRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RecordRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddRecordAsync(Record record)
        {
            _dbContext.Records.Add(record);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Record> GetRecordById(int id)
        {
             return await _dbContext.Records.FindAsync(id);
        }

        public async Task<IEnumerable<Record>> GetRecordsByUserIdAndCategoryId(int userId, int categoryId)
        {
            return await _dbContext.Records
                .Where(item => item.UserId == userId && item.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}
