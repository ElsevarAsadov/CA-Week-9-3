using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class DefaultDbContext : DbContext
    {
       public DbSet<WebApplication6.Models.Services> Services { get; set; }
       public DbSet<WebApplication6.Models.Emplooyes> Emplooyes { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder opts) {
            opts.UseSqlServer("Server=WINDOWS-2LETK0E;Database=SW;Trusted_Connection=True;");
        
        }
    }
}
