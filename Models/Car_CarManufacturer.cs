namespace UserControl.Models
{
    public class Car_CarManufacturer
    {
        public int CarmanId{ get; set; }
        public CarManufacturer CarManufacturer { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }
    }

}
