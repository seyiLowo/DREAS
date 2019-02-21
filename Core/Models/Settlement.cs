using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Settlement: BaseModel
    {
        /// <summary>
        /// beneficiary: the person receiving payment
        /// </summary>
        public Guid UserID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }

    }
}
