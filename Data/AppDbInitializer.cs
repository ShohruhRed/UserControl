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
                            ProfilePictureUrl = "https://www.dropbox.com/s/8r7puoizjevvvom/p1.jpg?dl=0",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                        new Car()
                        {
                            CarName = "Cayenne GT",
                            ProfilePictureUrl = "https://www.dropbox.com/s/psj74dzv8dvgfpb/c1.jpg?dl=0",
                            StartDate = DateTime.Now,
                            Description = "crossover"
                        },
                        new Car()
                        {
                            CarName = "911",
                            ProfilePictureUrl = "https://www.dropbox.com/s/5f2ldq8c6wliv4b/911.jpg?dl=0",
                            StartDate = DateTime.Now.AddDays(10),
                            Description = "sport"
                        },
                         new Car()
                        {
                            CarName = "RANGE ROVER SPORT",
                            ProfilePictureUrl = "https://www.dropbox.com/s/2ncgiyz1ktkdnxg/s1.jpg?dl=0",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                          new Car()
                        {
                            CarName = "RANGE ROVER VELAR",
                            ProfilePictureUrl = "https://www.dropbox.com/s/okn2yl0pzprxnxu/V1.jpg?dl=0",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                           new Car()
                        {
                            CarName = "RANGE ROVER EVOQUE",
                            ProfilePictureUrl = "https://www.dropbox.com/s/jukduji8ucpx6yf/E1.jpg?dl=0",
                            StartDate = DateTime.Now.AddDays(-200),
                            Description = "luxary"
                        },
                            new Car()
                        {
                            CarName = "Phantom",
                            ProfilePictureUrl = "https://www.dropbox.com/s/pqv9v4ylvist0f9/Ph1.jpg?dl=0",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                             new Car()
                        {
                            CarName = "Ghost",
                            ProfilePictureUrl = "https://www.dropbox.com/s/b30vx85zaxsas6d/Gh1.jpg?dl=0",
                            StartDate = DateTime.Now,
                            Description = "luxary"
                        },
                              new Car()
                        {
                            CarName = "Spectre",
                            ProfilePictureUrl = "https://www.dropbox.com/s/ptg6maeqz0qzmp5/Cl1.jpg?dl=0",
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
                            Logo = "https://www.dropbox.com/s/wuiiuk9fs600s11/Porsche_1.jpg?dl=0",
                            FoundationDate = DateTime.Now.AddDays(-1300) ,  
                            CarCategory = CarCategory.Sport
                        },

                       new CarManafacturer()
                        {
                            Name = "Range Rover",
                            Description = "Land Rover",
                            Logo = "https://www.dropbox.com/s/m1g2tcgkx42gan1/Land_Rover_1.jpg?dl=0",
                            FoundationDate = DateTime.Now.AddDays(-1300),
                            CarCategory = CarCategory.SUV
                        },
                       new CarManafacturer()
                        {
                            Name = "Rolls Royce",
                            Description = "lux",
                            Logo = "https://www.dropbox.com/s/hqpc09au5rdopl4/RolsRoyce_1.jpg?dl=0",
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
