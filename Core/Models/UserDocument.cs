using DREAS.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static DREAS.Models.Utility;

namespace Core.Models
{
    class UserDocument:BaseModel
    {
        public User User { get; set; }
        public DocumentType DocumentType { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileSize { get; set; }
        public string FileURL { get; set; }

    }
}
