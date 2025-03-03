using MakeOrder.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeOrder.Db
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
