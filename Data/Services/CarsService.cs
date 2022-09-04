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
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            var result = await _dbContext.Cars.ToListAsync();
            return result;
        }

        public Car GetById()
        {
            throw new NotImplementedException();
        }

        public Car Update(int id, Car newCar)
        {
            throw new NotImplementedException();
        }
    }
}
