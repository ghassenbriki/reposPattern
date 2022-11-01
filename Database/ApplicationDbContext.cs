using Microsoft.EntityFrameworkCore;
using reposPattern.Entities;

namespace reposPattern.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
