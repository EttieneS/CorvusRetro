using Microsoft.EntityFrameworkCore;

namespace RugbyManagementAPI.Models
{
    public class RugbyContext : DbContext
    {
        public RugbyContext(DbContextOptions<RugbyContext> options)
            : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-21KV94U\\SQLEXPRESS;Database=RugbyManagement;Trusted_Connection=True;encrypt=false");
        }

        internal object CreateObjectSet<T>()
        {
            throw new NotImplementedException();
        }
    }
}
