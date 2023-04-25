namespace Hospital.Booking.Data
{
    public class BookingMockDataService
    {
        public static List<Models.Booking> Bookings = new List<Models.Booking>()
          {
              new Models.Booking{Id =  1, Name = "Danusha", Sex = "Male", Age = 18, Address = "789 Veyangoda"},
              new Models.Booking{Id =  2, Name = "Pramodi", Sex = "Female", Age = 20, Address = "18/A Galle"},
              new Models.Booking{Id =  3, Name = "Mithila", Sex = "Male", Age = 15, Address = "68/B Koswattha"},
              new Models.Booking{Id =  4, Name = "Nipun", Sex = "Male", Age = 22, Address = "28 Naiwala"},
              new Models.Booking{Id =  5, Name = "Nadima", Sex = "Female", Age = 25, Address = "60/C Maharagama"}
          };
    }
}
