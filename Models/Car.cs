using System.ComponentModel.DataAnnotations;

namespace UserControl.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Display(Name = "Profile picture Url")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Car name")]
        public string CarName { get; set; }

        [Display(Name = "Car description")]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        //Relationship

        public List<Car_CarManufacturer> Cars_Manufacturers { get; set; }


    }
}
