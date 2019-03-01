using System;

namespace hoteltracker.Services.Impl
{
    public class MembershipService : IMembershipService
    {
        public int membershipLevel { get; set; }

        public int getMembershipLevel()
        {
            Console.WriteLine("Getting Membership Level.");
            throw new NotImplementedException();
        }
    }
}
