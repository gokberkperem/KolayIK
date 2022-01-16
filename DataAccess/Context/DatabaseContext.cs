using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        protected DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Personel> Personeller { get; set; }
    }
}
