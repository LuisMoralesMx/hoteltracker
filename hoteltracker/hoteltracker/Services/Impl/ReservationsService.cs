using hoteltracker.Models;
using System;

namespace hoteltracker.Services.Impl
{
    public class ReservationsService : IReservationsService
    {
        public int numberOfStayDays { get; set; }

        public string doCancelation(ReservationsModel reservations)
        {
            Console.WriteLine("Do cancelation: " + reservations.ToString());
            throw new NotImplementedException();
        }

        public string doReservation(ReservationsModel reservations)
        {
            Console.WriteLine("Do reservations: " + reservations.ToString());
            throw new NotImplementedException();
        }
    }
}
