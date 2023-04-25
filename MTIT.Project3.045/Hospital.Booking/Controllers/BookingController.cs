using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Hospital.Booking.Data;
using Hospital.Booking.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
        }

        // GET api/<BookingController>/5
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookingService.GetBooking());
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>

        // POST api/<BookingController>
        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return _bookingService.GetBooking(id) != null ? Ok(_bookingService.GetBooking(id)) : NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="booking"></param>



        // PUT api/<BookingController>/5
        [HttpPost]
        public IActionResult Post([FromBody] Models.Booking booking)
        {
            return Ok(_bookingService.AddBooking(booking));
        }

        /// <param name="booking"></param>

        [HttpPut]

        public IActionResult Put([FromBody] Models.Booking booking)
        {
            return Ok(_bookingService.UpdateBooking(booking));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// 

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _bookingService.DeleteBooking(id);

            return result.HasValue & result == true ? Ok($"booking with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the booking with Id: {id}.");
        }


    }
}