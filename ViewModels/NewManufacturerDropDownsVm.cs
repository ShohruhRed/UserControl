using UserControl.Models;

namespace UserControl.ViewModels
{
    public class NewManufacturerDropdownsVM
    {
        public NewManufacturerDropdownsVM()
        {
           
            Cars = new List<Car>();
        }       
        public List<Car> Cars { get; set; }
    }
}
