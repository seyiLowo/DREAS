using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Payment: BaseModel
    {
        public string Paymenttatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public string UserId { get; set; }
        public decimal PayMentAmount { get; set; }
        public Guid PropertyId { get; set; }
    }
}
