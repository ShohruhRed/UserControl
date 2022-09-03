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
        builder.Entity<Car_CarManafacturer>().HasKey(cm => new
        {
            cm.CarId,
            cm.CarmanId
        });

        builder.Entity<Car_CarManafacturer>().HasOne(m => m.CarManafacturer).WithMany(cm => cm.Cars_CarManafacturers).HasForeignKey(m =>
        m.CarmanId);

        builder.Entity<Car_CarManafacturer>().HasOne(m => m.Car).WithMany(cm => cm.Cars_Manafacturers).HasForeignKey(m =>
        m.CarId);

        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<CarManafacturer>  CarManafacturers { get; set; }
    public DbSet<Car_CarManafacturer> Cars_CarManafacturers { get; set; }
}
