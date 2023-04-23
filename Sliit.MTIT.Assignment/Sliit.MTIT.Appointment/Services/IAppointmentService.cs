namespace Sliit.MTIT.Appointment.Services
{
    public interface IAppointmentService
    {
        List<Models.Appointment> GetAppointment();
        Models.Appointment? GetAppointment(int id);
        Models.Appointment? AddAppointment(Models.Appointment appointment);
        Models.Appointment? UpdateAppointment(Models.Appointment appointment);
        bool? DeleteAppointment(int id);
    }
}
