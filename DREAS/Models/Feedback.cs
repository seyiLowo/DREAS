using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Feedback : BaseModel
    {
        public Guid FeedbackID { get; set; }
        public Guid FeedbackBy { get; set; }
        public Guid PropertyID { get; set; }
        public Guid FeedbackFor { get; set; }
        public string Message { get; set; }

    }
}
