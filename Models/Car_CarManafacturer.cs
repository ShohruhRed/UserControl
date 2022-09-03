namespace UserControl.Models
{
    public class Car_CarManafacturer
    {
        public int CarmanId{ get; set; }
        public CarManafacturer CarManafacturer { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }
    }

}
