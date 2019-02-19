using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Role: BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

