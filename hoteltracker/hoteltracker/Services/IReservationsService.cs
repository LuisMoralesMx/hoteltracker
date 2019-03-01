using hoteltracker.Models;

namespace hoteltracker.Services
{
    public interface IReservationsService
    {
        int numberOfStayDays { get; set; }

        string doReservation(ReservationsModel reservations);
        string doCancelation(ReservationsModel reservations);
    }
}
