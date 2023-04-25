using Hospital.Booking.Data;
using Hospital.Booking.Models;


namespace Hospital.Booking.Services
{
    public class BookingService : IBookingService
    {
        public List<Models.Booking> GetBooking()
        {
            return BookingMockDataService.Bookings;
        }

        public Models.Booking? GetBooking(int id)
        {
            return BookingMockDataService.Bookings.FirstOrDefault(x => x.Id == id);
        }

        public Models.Booking? AddBooking(Models.Booking booking)
        {
            BookingMockDataService.Bookings.Add(booking);
            return booking;
        }

        public Models.Booking? UpdateBooking(Models.Booking booking)
        {
            Models.Booking selectedBooking = BookingMockDataService.Bookings.FirstOrDefault(x => x.Id == booking.Id);
            if (selectedBooking != null)
            {
                selectedBooking.Address = booking.Address;
                selectedBooking.Age = booking.Age;
                selectedBooking.Name = booking.Name;
                selectedBooking.Sex = booking.Sex;
                return selectedBooking;
            }
            return selectedBooking;
        }

        public bool? DeleteBooking(int id)
        {
            Models.Booking selectedBooking = BookingMockDataService.Bookings.FirstOrDefault(x => x.Id == id);
            if (selectedBooking != null)
            {
                BookingMockDataService.Bookings.Remove(selectedBooking);
                return true;
            }
            return false;
        }
    }
}
