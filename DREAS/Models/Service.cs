using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Service : BaseModel
    {
        public string Description { get; set; }
        public ServiceType Type { get; set; }
    }
}
