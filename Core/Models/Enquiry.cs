using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Enquiry: BaseModel
    {
        public Guid PropertyID { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string FAQ { get; set; }

    }
}
