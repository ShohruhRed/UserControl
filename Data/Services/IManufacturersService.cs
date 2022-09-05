using UserControl.Data.Base;
using UserControl.Models;
using UserControl.ViewModels;

namespace UserControl.Data.Services
{
    public interface IManufacturersService : IEntityBaseRepository<CarManufacturer>
    {
        Task<CarManufacturer> GetManufacturerByIdAsync(int id);
        Task<NewManufacturerDropdownsVM> GetNewManufacturerDropdownsValues();
        Task AddNewManufacturerAsync(NewManufacturerVM data);
        Task UpdateManufacturerAsync(NewManufacturerVM data);
    }
}
