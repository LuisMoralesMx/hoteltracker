using System.Collections.Generic;

namespace hoteltracker.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int membershipLevel { get; set; }
        public List<object> discounts { get; set; }
    }
}
