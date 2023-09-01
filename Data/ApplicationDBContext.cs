using Microsoft.EntityFrameworkCore;
namespace TimerApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<History> history { get; set; }
    }
}