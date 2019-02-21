using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Property: BaseModel
    {
        public PropertyStatus Status { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("User")]
        public Guid OwnerID { get; set; }
        public User Owner { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public Address Address { get; set; }
        public PropertyCategory Category { get; set; }
        public PropertyType Type { get; set; }
        public string Details { get; set; }

    }
}
