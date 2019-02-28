using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class PropertyCategory: BaseModel
    {
        public string Duplex { get; set; }
        public String HalfDuplex { get; set; }
        public string Terrace { get; set; }
        public string Flat { get; set; }
        public int RoomNo { get; set; }
    }
}
