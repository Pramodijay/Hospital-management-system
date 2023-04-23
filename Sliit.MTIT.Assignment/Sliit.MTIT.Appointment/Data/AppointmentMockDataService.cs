namespace Sliit.MTIT.Appointment.Data
{
    public class AppointmentMockDataService
    {
        public static List<Models.Appointment> Appointments = new List<Models.Appointment>()
        {
            new Models.Appointment { Id = 1, Name = "Mithila", Date = "01/04/2023", ContactNo = 0711888655 },
            new Models.Appointment { Id = 2, Name = "Suresh", Date = "02/04/2023", ContactNo = 0757893542 },
            new Models.Appointment { Id = 3, Name = "Anjana", Date = "03/04/2023", ContactNo = 0776583497 },
            new Models.Appointment { Id = 4, Name = "Nimesh", Date = "04/04/2023", ContactNo = 0709873572 },
            new Models.Appointment { Id = 5, Name = "Sahan", Date = "05/04/2023", ContactNo = 0663684987 }
        };
    }
}
