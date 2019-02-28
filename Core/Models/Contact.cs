using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Contact
    {
        [Required(ErrorMessage= "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public Address Address { get; set; }
    }
}
