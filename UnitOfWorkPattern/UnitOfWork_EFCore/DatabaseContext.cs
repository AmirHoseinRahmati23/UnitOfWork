using Microsoft.EntityFrameworkCore;

namespace UnitOfWork_EFCore
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}