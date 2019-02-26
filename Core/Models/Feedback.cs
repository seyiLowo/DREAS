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


        public Property Property { get; set; }
        public Guid PropertyID { get; set; }

        public User User { get; set; }
        public Guid UserID { get; set; }

        public string FeedbackMessage { get; set; }

        private RoleType roleTypes;
        public List<Role> Roles { get; set; }


        public Feedback(RoleType roleType)
        {
            this.roleTypes = roleType;

            switch (roleType)
            {
                case RoleType.Client:
                    clientID = UserID;
                    break;
                case RoleType.Agent:
                    serviceProviderID = UserID;
                    break;
                case RoleType.LandLord:
                    serviceProviderID = UserID;
                    break;
                case RoleType.Insurance:
                    serviceProviderID = UserID;
                    break;
                case RoleType.Legal:
                    serviceProviderID = UserID;
                    break;
                case RoleType.Artisan:
                    serviceProviderID = UserID;
                    break;
                default:
                    break;
            }
        }
    }
}
