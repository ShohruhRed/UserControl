using System.ComponentModel.DataAnnotations;
using UserControl.Data;

namespace UserControl.Models
{
    public class CarManafacturer
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime FoundationDate { get; set; }

        public CarCategory CarCategory { get; set; }
    }
}
