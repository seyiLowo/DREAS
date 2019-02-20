using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class propertyList: BaseModel
    {
        public Guid PropertyListID { get; set; }
        public Guid PropertyID { get; set; }
        public Guid UserID { get; set; }
    }
}
