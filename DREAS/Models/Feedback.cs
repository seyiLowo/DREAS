using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    class Feedback : BaseModel
    {
        public Guid clientID;
        public Guid serviceProviderID;

        public Property PropertyID { get; set; }
        public string FeedbackMessage { get; set; }

        private Roles roles;


        public Feedback(Roles roles)
        {
            this.roles = roles;

            switch (roles)
            {
                case Roles.client:
                    clientID = ID;
                    break;
                case Roles.agent:
                    serviceProviderID = ID;
                    break;
                case Roles.landlord:
                    serviceProviderID = ID;
                    break;
                case Roles.insurance:
                    serviceProviderID = ID;
                    break;
                case Roles.digitalLegal:
                    serviceProviderID = ID;
                    break;
                case Roles.artisan:
                    serviceProviderID = ID;
                    break;
                default:
                    break;
            }
        }
    }
}
