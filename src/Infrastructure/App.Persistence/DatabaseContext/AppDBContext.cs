using App.Domain.Common;
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.DatabaseContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity<int>>())
            {
                if(entry.State==EntityState.Added)
                    entry.Entity.CreatedDate = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Entity.ModifiedDate = DateTime.Now;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
