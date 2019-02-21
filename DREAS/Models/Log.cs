using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Log: BaseModel
    {
        public Guid UserID { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public string IPAddress { get; set; }
        public ActionType ActionType { get; set; }
        public ActionStatus Status { get; set; }
    }
}
