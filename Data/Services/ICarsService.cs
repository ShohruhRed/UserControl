using UserControl.Models;

namespace UserControl.Data.Services
{
    public interface ICarsService
    {
        Task<IEnumerable<Car>> GetAll();
        Car GetById();
        void Add(Car car);
        Car Update(int id, Car newCar);
        void Delete(int id);
    }
}
