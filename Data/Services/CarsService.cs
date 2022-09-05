using Microsoft.EntityFrameworkCore;
using UserControl.Models;

namespace UserControl.Data.Services
{
    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext _dbContext;
        public CarsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Car car)
        {
            await _dbContext.Cars.AddAsync(car);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            var result = await _dbContext.Cars.ToListAsync();
            return result;
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            var result = await _dbContext.Cars.FirstOrDefaultAsync(n => n.CarId == id);
            return result;
        }

        public Car Update(int id, Car newCar)
        {
            throw new NotImplementedException();
        }        
    }
}
