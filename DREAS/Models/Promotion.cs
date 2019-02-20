using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Promotion: BaseModel
    {
        public Guid PromotionID { get; set; }
        public DateTime PromotionDate { get; set; }
        public string  PromotionDescription { get; set; }
        public string PromotionName { get; set; }
    }
}
