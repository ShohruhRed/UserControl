using UserControl.Models;

namespace UserControl.Data.Services
{
    public interface ICarsService
    {
        Task<IEnumerable<Car>> GetAllAsync();
        Task<Car> GetByIdAsync(int id);
        Task AddAsync(Car car);
        Task<Car> UpdateAsync(int id, Car newCar);
        Task DeleteAsync(int id);
    }
}
