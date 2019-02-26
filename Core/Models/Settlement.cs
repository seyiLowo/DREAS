using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Settlement: BaseModel
    {
        //beneficiary: the person receiving payment
       
        public Guid UserID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }

    }
}
