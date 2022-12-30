using Microsoft.EntityFrameworkCore;

namespace HairDressR.Models
{
    public class HairDressRContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=data.db");
    }
}
