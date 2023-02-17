using Microsoft.EntityFrameworkCore;

namespace DispatcherWebApp.Models
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {
        }

        public DbSet<OrdersEntity> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrdersEntity>()
            .ToTable("Orders")
            .HasKey(m => new { m.IDPlant, m.IDOrder });

        }


    }
}