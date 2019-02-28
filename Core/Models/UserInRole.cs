using DREAS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class UserInRole:BaseModel
    {
        public virtual User User { get; set; }
        public virtual  Role Role { get; set; }


    }
}
