using hoteltracker.Models;
using System;

namespace hoteltracker.Services
{
    public class ReservationsService : IReservationsService
    {
        public int numberOfStayDays { get; set; }

        public string doCancelation()
        {
            throw new NotImplementedException();
        }

        public string doReservation(ReservationsModel reservations)
        {
            Console.WriteLine("Do reservations: " + reservations.ToString());
            throw new NotImplementedException();
        }
    }
}
