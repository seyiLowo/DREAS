using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Payment: BaseModel
    {
        public PaymentStatus Status { get; set; }
        public DateTime Date { get; set; }
        public Guid UserID { get; set; }
        public decimal Amount { get; set; }
        public Guid ServiceID { get; set; }
    }
}
