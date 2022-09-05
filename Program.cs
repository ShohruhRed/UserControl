using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserControl.Data;
using UserControl.Data.Services;
using UserControl.Models;

namespace UserControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.Password.RequiredLength = 1;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedAccount = false;
                options.Lockout.AllowedForNewUsers = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();
            
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();

            builder.Services.AddTransient<IUsers, Users>();
            builder.Services.AddScoped<ICarsService, CarsService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                //builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
                //{
                //    options.Password.RequiredLength = 1;
                //    options.Password.RequiredUniqueChars = 0;
                //    options.Password.RequireLowercase = false;
                //    options.Password.RequireUppercase = false;
                //    options.Password.RequireDigit = false;
                //    options.Password.RequireNonAlphanumeric = false;
                //    options.SignIn.RequireConfirmedAccount = false;
                //});
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Manufacturers}/{action=Index}/{id?}");
            app.MapRazorPages();

            AppDbInitializer.Seed(app);

            app.Run();
        }
    }
}