using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class PropertyList: BaseModel
    {
        public  PropertyCategory PropertyCategory { get; set; }
        public Guid PropertyID { get; set; }
        public PropertyType Type { get; set; }
        public Guid UserID { get; set; }
    }
}
