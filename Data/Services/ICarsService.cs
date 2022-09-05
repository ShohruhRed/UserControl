using UserControl.Models;

namespace UserControl.Data.Services
{
    public interface ICarsService
    {
        Task<IEnumerable<Car>> GetAllAsync();
        Task<Car> GetByIdAsync(int id);
        Task AddAsync(Car car);
        Car Update(int id, Car newCar);
        void Delete(int id);
    }
}
