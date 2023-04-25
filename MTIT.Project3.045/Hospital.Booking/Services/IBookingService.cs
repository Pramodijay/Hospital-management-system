namespace Hospital.Booking.Services
{
    public interface IBookingService
    {
        List<Models.Booking> GetBooking();
        Models.Booking? GetBooking(int id);
        Models.Booking? AddBooking(Models.Booking booking);
        Models.Booking? UpdateBooking(Models.Booking booking);
        bool? DeleteBooking(int id);
    }
}
