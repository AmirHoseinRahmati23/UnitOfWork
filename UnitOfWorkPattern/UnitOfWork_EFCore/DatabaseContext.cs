using Microsoft.EntityFrameworkCore;

namespace UnitOfWork
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}