using System;

namespace hoteltracker.Models
{
    public class ReservationsModel
    {
        public int reservationId { get; set; }
        public int destination { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public int userId { get; set; }
    }
}
