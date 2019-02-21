using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Transaction: BaseModel
    {
        public Guid PropertyID { get; set; }
        public string ReferenceNo { get; set; }
        public string Description { get; set; }
        public ServiceType Type { get; set; }
    }
}
