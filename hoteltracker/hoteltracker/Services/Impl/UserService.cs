using hoteltracker.Models;

namespace hoteltracker.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IMembershipService _membershipService;
        private readonly IDiscountsService _discountsService;

        public UserService(IMembershipService membershipService, IDiscountsService discountsService)
        {
            this._membershipService = membershipService;
            this._discountsService = discountsService;
        }

        public UserModel getUserProfileData()
        {
            UserModel user = new UserModel();
            user.id = 1;
            user.firstName = "John";
            user.lastName = "Doe";
            user.email = "user@email.com";
            user.membershipLevel = this._membershipService.getMembershipLevel();
            user.discounts = this._discountsService.getUserDiscountsList();

            return user;
        }
    }
}
