using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class CompanyProfile: BaseModel
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string CAC { get; set; }
        public string ContactPersonnel { get; set; }
    }
}
