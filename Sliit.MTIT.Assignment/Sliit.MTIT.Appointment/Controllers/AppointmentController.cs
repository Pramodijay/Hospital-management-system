using System.Reflection.Metadata.Ecma335;
using Sliit.MTIT.Appointment.Data;
using Sliit.MTIT.Appointment.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Appointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService ?? throw new ArgumentNullException(nameof(appointmentService));
        }


        /// <summary>
        /// Get all Appointments
        /// </summary>
        /// <returns>return the list of Appointments</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appointmentService.GetAppointment());
        }

        /// <summary>
        /// Get Appointment by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Appointment with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _appointmentService.GetAppointment(id) != null ? Ok(_appointmentService.GetAppointment(id)) : NoContent();
        }

        /// <summary>
        /// Add Appointments
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Return the added Appointment</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Appointment appointment)
        {
            return Ok(_appointmentService.AddAppointment(appointment));
        }

        /// <summary>
        /// Update the Appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>Return the updated Appointment</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Appointment appointment)
        {
            return Ok(_appointmentService.UpdateAppointment(appointment));
        }

        /// <summary>
        /// Delete the Appointment with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _appointmentService.DeleteAppointment(id);

            return result.HasValue & result == true ? Ok($"appointment with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the appointment with ID:{id}.");
        }
    }
}
