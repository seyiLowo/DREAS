using DREAS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static DREAS.Models.Utility;

namespace Core.Models
{
    class Risk:BaseModel
    {
        public User UserID { get; set; }
        public Property Property { get; set; }
        public decimal InsuredAmount { get; set; }
        public string InsuredName { get; set; }
        public decimal SumInsured { get; set; }
        public decimal Rate { get; set; }
        public decimal Premium { get; set; }
        public RiskType RiskType { get; set; }
        public string Insurer { get; set; }
    }
}
