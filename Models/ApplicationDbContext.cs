using Microsoft.EntityFrameworkCore;

namespace Amazing_Barley_By_CjYan.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // If you already have model classes, add DbSet<> lines here later.
        // Example:
        // public DbSet<User> Users { get; set; }
    }
}
