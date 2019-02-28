using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class BaseModel
    {
        public Guid ID { get; set; }
        public DateTime EntryDate { get; set; }
        public Guid EntryBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}
