using hoteltracker.Models;
using hoteltracker.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hoteltracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReservationsService _reservationsService;
        private readonly IUserService _userService;

        public HomeController(IReservationsService reservationService, IUserService userService)
        {
            this._reservationsService = reservationService;
            this._userService = userService;
        }

        public IActionResult Index()
        {
            var user = (UserModel)_userService.getUserProfileData();
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            _reservationsService.doReservation();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
