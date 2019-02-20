using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Transaction: BaseModel
    {
        public Guid TransactionID { get; set; }
        public Guid PropertyID { get; set; }
        public Guid TransactionReferenceNum { get; set; }
    }
}
