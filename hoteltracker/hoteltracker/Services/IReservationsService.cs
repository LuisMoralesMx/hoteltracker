namespace hoteltracker.Services
{
    public interface IReservationsService
    {
        int numberOfStayDays { get; set; }

        string doReservation();
        string doCancelation();
    }
}
