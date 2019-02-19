using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class UserProfile: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Guid AddressId { get; set; }
        public string  Email { get; set; }
        public int ReferalCode { get; set; }
    }
}
