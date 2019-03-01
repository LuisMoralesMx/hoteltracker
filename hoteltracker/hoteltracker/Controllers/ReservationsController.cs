using hoteltracker.Models;
using hoteltracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace hoteltracker.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationsService _reservationsService;

        public ReservationsController(IReservationsService reservationService)
        {
            this._reservationsService = reservationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reservation(ReservationsModel reservations)
        {
            _reservationsService.doReservation(reservations);
            return View();
        }
    }
}