using System.Collections.Generic;

namespace hoteltracker.Services
{
    public interface IMembershipService
    {
        int membershipLevel { get; set; }        
        int getMembershipLevel();        
    }
}
