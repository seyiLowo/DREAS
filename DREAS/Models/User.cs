using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class User: BaseModel
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
