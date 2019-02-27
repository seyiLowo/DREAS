using System.ComponentModel.DataAnnotations;

namespace DREAS.Models
{
    public class Address
    {
        [Required(ErrorMessage = "HouseNO is required")]
        public string HouseNo { get; set; }
        [Required(ErrorMessage = "StreetName is required")]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "LGA is required")]
        public string LGA { get; set; }
        [Required(ErrorMessage = "State is required")]
        public string State { get; set; }

    }
}