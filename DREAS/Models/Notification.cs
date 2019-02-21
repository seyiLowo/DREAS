using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Notification: BaseModel
    {
        public Contact Email { get; set; }
        public int PropertyID { get; set; }
        public Enquiry Message { get; set; }
        public Guid UserID { get; set; }

    }
}
