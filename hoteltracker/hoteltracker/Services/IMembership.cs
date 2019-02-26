using System.Collections.Generic;

namespace hoteltracker.Services
{
    public interface IMembership
    {
        int membershipLevel { get; set; }
        List<object> discounts { get; set; }

        int getMembershipLevel();
        List<object> getDiscountsList();
    }
}
