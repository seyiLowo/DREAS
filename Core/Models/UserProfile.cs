namespace DREAS.Models
{
    public class UserProfile: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Contact Contact { get; set; }
        public int ReferalCode { get; set; }
        public string BVN { get; set; }
        public string NIN { get; set; }

    }
}
