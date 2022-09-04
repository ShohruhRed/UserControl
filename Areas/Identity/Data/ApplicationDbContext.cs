using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserControl.Data;
using UserControl.Models;

namespace UserControl.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Car_CarManufacturer>().HasKey(cm => new
        {
            cm.CarId,
            cm.CarmanId
        });

        builder.Entity<Car_CarManufacturer>().HasOne(m => m.CarManufacturer).WithMany(cm => cm.Cars_CarManufacturers).HasForeignKey(m =>
        m.CarmanId);

        builder.Entity<Car_CarManufacturer>().HasOne(m => m.Car).WithMany(cm => cm.Cars_Manufacturers).HasForeignKey(m =>
        m.CarId);

        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<CarManufacturer>  CarManufacturers { get; set; }
    public DbSet<Car_CarManufacturer> Cars_CarManufacturers { get; set; }
}
