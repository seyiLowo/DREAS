using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Transaction: BaseModel
    {
        public Guid TransactionId { get; set; }
        public Guid PropertyId { get; set; }
        public Guid TransactionReferenceNum { get; set; }
    }
}
