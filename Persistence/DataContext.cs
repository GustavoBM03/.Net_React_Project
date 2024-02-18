using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        //    Seed.SeedData(modelBuilder);
            
        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Activity> Activities { get; set; }
    }
}