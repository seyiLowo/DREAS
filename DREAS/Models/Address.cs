namespace DREAS.Models
{
    public class Address: BaseModel
    {
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string LGA { get; set; }
        public string State { get; set; }

    }
}