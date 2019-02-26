namespace hoteltracker.Services
{
    public interface IRooms
    {
        int numberOfBeds { get; set; }
        string roomType { get; set; }

        int getNumberOfBeds();
        string getRoomType(); 
    }
}
