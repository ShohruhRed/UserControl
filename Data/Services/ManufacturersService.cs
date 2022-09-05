using Microsoft.EntityFrameworkCore;
using UserControl.Data.Base;
using UserControl.Models;
using UserControl.ViewModels;

namespace UserControl.Data.Services
{
    public class ManufacturersService : EntityBaseRepository<CarManufacturer>, IManufacturersService
    {
        private readonly ApplicationDbContext _context;
        public ManufacturersService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewManufacturerAsync(NewManufacturerVM data)
        {
            var newManufacturer = new CarManufacturer()
            {
                Name = data.Name,
                Description = data.Description,
                Logo = data.ImageURL,
                FoundationDate = data.FoundationDate,
                CarCategory = data.CarCategory

            };
            await _context.CarManufacturers.AddAsync(newManufacturer);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var carId in data.CarIds)
            {
                var newActorMovie = new Car_CarManufacturer()
                {
                    CarmanId = data.Id,
                    CarId = carId
                };
                await _context.Cars_CarManufacturers.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
        public async Task<CarManufacturer> GetManufacturerByIdAsync(int id)
        {
            var movieDetails = await _context.CarManufacturers
                .Include(c => c.Cars_CarManufacturers).ThenInclude(c => c.Car)
                .FirstOrDefaultAsync(n => n.Id == id);
            return movieDetails;
        }


        public async Task<NewManufacturerDropdownsVM> GetNewManufacturerDropdownsValues()
        {
            var response = new NewManufacturerDropdownsVM()
            {
                Cars = await _context.Cars.OrderBy(n => n.CarName).ToListAsync(),

            };

            return response;
        }

        public async Task UpdateManufacturerAsync(NewManufacturerVM data)
        {
            var dbManufacturer = await _context.CarManufacturers.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbManufacturer != null)
            {
                dbManufacturer.Name = data.Name;
                dbManufacturer.Description = data.Description;
                dbManufacturer.FoundationDate = data.FoundationDate;
                dbManufacturer.CarCategory = data.CarCategory;
                await _context.SaveChangesAsync();
            }

            //Remove existing actors
            var existingCarsDb = _context.Cars_CarManufacturers.Where(n => n.CarmanId == data.Id).ToList();
            _context.Cars_CarManufacturers.RemoveRange(existingCarsDb);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var carId in data.CarIds)
            {
                var newCarManufacturer = new Car_CarManufacturer()
                {
                    CarmanId = data.Id,
                    CarId = data.Id
                };
                await _context.Cars_CarManufacturers.AddAsync(newCarManufacturer);
            }
            await _context.SaveChangesAsync();
        }
    }
}

