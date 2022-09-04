using UserControl.Models;

namespace UserControl.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Cars
                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(new List<Car>()
                    {
                        new Car()
                        {
                            CarName = "Panamera Turbo S",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                        new Car()
                        {
                            CarName = "Cayenne GT",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now,
                            Description = "crossover"
                        },
                        new Car()
                        {
                            CarName = "911",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now.AddDays(10),
                            Description = "sport"
                        },
                         new Car()
                        {
                            CarName = "RANGE ROVER SPORT",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                          new Car()
                        {
                            CarName = "RANGE ROVER VELAR",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                           new Car()
                        {
                            CarName = "RANGE ROVER EVOQUE",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                            new Car()
                        {
                            CarName = "Phantom",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                             new Car()
                        {
                            CarName = "Ghost",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                              new Car()
                        {
                            CarName = "Spectre",
                            ProfilePictureUrl = "",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },

                    });
                    context.SaveChanges();
                }

                //CarManafacturers
                if (!context.CarManafacturers.Any())
                {
                    context.CarManafacturers.AddRange(new List<CarManafacturer>()
                    {
                        new CarManafacturer()
                        {
                            Name = "Porsche",
                            Description = "Sport cars",
                            Logo = "",
                            FoundationDate = DateTime.Now.AddDays(-1300) ,  
                            CarCategory = CarCategory.Sport
                        },

                       new CarManafacturer()
                        {
                            Name = "Range Rover",
                            Description = "Land Rover",
                            Logo = "",
                            FoundationDate = DateTime.Now.AddDays(-1300),
                            CarCategory = CarCategory.SUV
                        },
                       new CarManafacturer()
                        {
                            Name = "Rolls Royce",
                            Description = "lux",
                            Logo = "",
                            FoundationDate = DateTime.Now.AddDays(-1300),
                            CarCategory = CarCategory.Luxary
                        }

                    });
                    context.SaveChanges();
                }

                //Cars & Manafacturers
                if (!context.Cars_CarManafacturers.Any())
                {
                    context.Cars_CarManafacturers.AddRange(new List<Car_CarManafacturer>()
                    {
                        new Car_CarManafacturer()
                        {
                            CarId = 1,
                            CarmanId = 1
                        },
                        new Car_CarManafacturer()
                        {
                            CarId = 2,
                            CarmanId = 1
                        },
                        new Car_CarManafacturer()
                        {
                            CarId = 3,
                            CarmanId = 1
                        },
                         new Car_CarManafacturer()
                        {
                            CarId = 4,
                            CarmanId = 2
                        },
                        new Car_CarManafacturer()
                        {
                            CarId = 5,
                            CarmanId = 2
                        },
                        new Car_CarManafacturer()
                        {
                            CarId = 6,
                            CarmanId = 2,
                        },
                         new Car_CarManafacturer()
                        {
                            CarId = 7,
                            CarmanId = 3
                        },
                        new Car_CarManafacturer()
                        {
                            CarId = 8,
                            CarmanId = 3
                        },
                        new Car_CarManafacturer()
                        {
                            CarId = 9,
                            CarmanId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
