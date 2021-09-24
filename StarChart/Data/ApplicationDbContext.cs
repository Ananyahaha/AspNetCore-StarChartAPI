using Microsoft.EntityFrameworkCore;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelestialObject> CelestialObjects;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }

}
