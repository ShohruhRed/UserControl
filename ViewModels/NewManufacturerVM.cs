using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using UserControl.Data;

namespace UserControl.ViewModels
{
    public class NewManufacturerVM
    {
        public int Id { get; set; }

        [Display(Name = "Manufaturer name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Manufaturer name description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }        

        [Display(Name = "Manufaturer name poster URL")]
        [Required(ErrorMessage = "Manufaturer name poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Manufaturer name foundation date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime FoundationDate { get; set; }
       

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Manufaturer category is required")]
        public CarCategory CarCategory { get; set; }

        //Relationships
        [Display(Name = "Select a car(s)")]
        [Required(ErrorMessage = "Manfacturer car(s) is required")]
        public List<int> CarIds { get; set; }

    
    }
}
