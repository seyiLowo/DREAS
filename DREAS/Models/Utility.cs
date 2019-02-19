using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREAS.Models
{
    public class Utility
    {
        public enum PropertyStatus
        {
            Draft,
            Pending,
            Approved
        }
        public enum RoleType
        {
            Client,
            Agent,
            LandLord,
            Insurance,
            Legal,
            Artisan
        }

        public enum PaymentStatus
        {
            Pending,
            Failed,
            Successful
        }

        public enum ServiceType
        {
            Property,
            Moving,
            Legal,
            Insurance
        }
    }
}
