using System.ComponentModel.DataAnnotations;

namespace UserControl.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        public string ProfilePictureUrl { get; set; }
        public string CarName { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        //Relationship

        public List<Car_CarManafacturer> Cars_Manafacturers { get; set; }


    }
}
