using Microsoft.EntityFrameworkCore;

namespace AkademiPlusSignalR2.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-1MSR6CD\\SQLEXPRESS;initial catalog=DbSignalR2;integrated security=true");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
