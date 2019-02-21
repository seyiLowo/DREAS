using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Promotion: BaseModel
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Guid PropertyID { get; set; }
        public string ImageURL { get; set; }
    }
}
