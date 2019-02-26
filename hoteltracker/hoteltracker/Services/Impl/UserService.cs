using hoteltracker.Models;

namespace hoteltracker.Services
{
    public class UserService : IUserService
    {
        public UserModel getUserProfileData()
        {
            UserModel user = new UserModel();
            user.id = 1;
            user.firstName = "John";
            user.lastName = "Doe";
            user.email = "user@email.com";

            return user;
        }
    }
}
