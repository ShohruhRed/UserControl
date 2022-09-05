using System.ComponentModel.DataAnnotations;
using UserControl.Data;
using UserControl.Data.Base;

namespace UserControl.Models
{
    public class CarManufacturer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime FoundationDate { get; set; }

        public CarCategory CarCategory { get; set; }

        //Relationships

        public List<Car_CarManufacturer> Cars_CarManufacturers { get; set; }
    }
}
