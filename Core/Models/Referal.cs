using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Referal: BaseModel
    {
        public Guid UserID { get; set; }
        public int ReferalCode { get; set; }
    }
}
