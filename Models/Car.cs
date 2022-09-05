﻿using System.ComponentModel.DataAnnotations;

namespace UserControl.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Display(Name = "Profile picture Url")]
        [Required(ErrorMessage ="Profile picture is required")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Car name")]
        [Required(ErrorMessage = "Car name is required")]
        public string CarName { get; set; }

        [Display(Name = "Car description")]
        [Required(ErrorMessage = "Car description is required")]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        //Relationship

        public List<Car_CarManufacturer> Cars_Manufacturers { get; set; }


    }
}
