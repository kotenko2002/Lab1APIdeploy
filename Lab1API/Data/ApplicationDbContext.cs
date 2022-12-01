using Lab1API.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Сurrency> Currencies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }
    }
}
