using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Log: BaseModel
    {
        public User UserFullName { get; set; }
        public string Message { get; set; }
        public string IPAddress { get; set; }
        public Guid RoleID { get; set; }
        public string LocalIPAddress { get; set; }
    }
}
