using hoteltracker.Models;

namespace hoteltracker.Services
{
    public interface IReservationsService
    {
        int numberOfStayDays { get; set; }

        string doReservation(ReservationsModel reseervations);
        string doCancelation();
    }
}
