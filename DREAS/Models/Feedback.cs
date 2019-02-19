using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class Feedback : BaseModel
    {
        public Guid clientID;
        public Guid serviceProviderID;

        public Property PropertyID { get; set; }
        public string FeedbackMessage { get; set; }

        private RoleType roleTypes;


        public Feedback(RoleType roleType)
        {
            this.roleTypes = roleType;

            switch (roleType)
            {
                case RoleType.Client:
                    clientID = ID;
                    break;
                case RoleType.Agent:
                    serviceProviderID = ID;
                    break;
                case RoleType.LandLord:
                    serviceProviderID = ID;
                    break;
                case RoleType.Insurance:
                    serviceProviderID = ID;
                    break;
                case RoleType.Legal:
                    serviceProviderID = ID;
                    break;
                case RoleType.Artisan:
                    serviceProviderID = ID;
                    break;
                default:
                    break;
            }
        }
    }
}
