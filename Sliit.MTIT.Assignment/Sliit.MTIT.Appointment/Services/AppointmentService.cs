using Sliit.MTIT.Appointment.Data;
using Sliit.MTIT.Appointment.Models;

namespace Sliit.MTIT.Appointment.Services
{
    public class AppointmentService:IAppointmentService
    {
        public List<Models.Appointment> GetAppointment()
        {
            return AppointmentMockDataService.Appointments;
        }

        public Models.Appointment? GetAppointment(int id)
        {
            return AppointmentMockDataService.Appointments.FirstOrDefault(x => x.Id == id);
        }

        public Models.Appointment? AddAppointment(Models.Appointment appointment)
        {
            AppointmentMockDataService.Appointments.Add(appointment);
            return appointment;
        }

        public Models.Appointment? UpdateAppointment(Models.Appointment appointment)
        {
            Models.Appointment selectedAppointment = AppointmentMockDataService.Appointments.FirstOrDefault(x => x.Id == appointment.Id);
            if (selectedAppointment != null)
            {
                selectedAppointment.Date = appointment.Date;
                selectedAppointment.ContactNo = appointment.ContactNo;
                selectedAppointment.Name = appointment.Name;
                return selectedAppointment;
            }

            return selectedAppointment;
        }

        public bool? DeleteAppointment(int id)
        {
            Models.Appointment selectedAppointment = AppointmentMockDataService.Appointments.FirstOrDefault(x => x.Id == id);
            if (selectedAppointment != null)
            {
                AppointmentMockDataService.Appointments.Remove(selectedAppointment);
                return true;
            }
            return false;
        }
    }
}
