using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class UserProfile: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Contact  ContactDetails { get; set; }
        public int ReferalCode { get; set; }

    }
}
