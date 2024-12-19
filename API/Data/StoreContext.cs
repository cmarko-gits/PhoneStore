using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Product>()
        .OwnsOne(p => p.Specifications, specification =>
        {
            specification.Property(s => s.CPU);
            specification.Property(s => s.ScreenSize);
            specification.Property(s => s.ScreenType);
            specification.Property(s => s.RAM);
            specification.Property(s => s.InternalStorage);
            specification.Property(s => s.BatteryCapacity);
            specification.Property(s => s.FastCharging);
            specification.Property(s => s.FastChargingWatt);
            specification.Property(s => s.WirelessCharging);
            specification.Property(s => s.Brand);
            specification.Property(s => s.OperatingSystem);

          
        });
}

        }
    }

