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

        public enum ActionType
        {
            Created,
            Updated,
            Read,
            Deleted
        }

        public enum ActionStatus
        {
            Failed,
            Successful
        }

        public enum PropertyType
        {
            Rent,
            Sale,
            Lease
        }
        public enum UserType
        {
            Company,
            Group,
            Individual
        }
        public enum DocumentType
        {
            Legal
        }
        public enum RiskType
        {
            Fire,
            HouseHold,
            Burgulary,
            Bond

        }
    }
}
