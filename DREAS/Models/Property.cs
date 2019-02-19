using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Property: BaseModel
    {
        public PropertyStatus Status { get; set; }
        public decimal Price { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public Guid AddressID { get; set; }
        public Address Address { get; set; }

    }
}
