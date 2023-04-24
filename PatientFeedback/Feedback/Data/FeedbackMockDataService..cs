using System.Reflection;

namespace Feedback.Data
{
    public class FeedbackMockDataService
    {
        public static List<Models.Feedback> Feedbacks = new List<Models.Feedback>()
       {
            new Models.Feedback { Id = 1, Name = "Ishara", feedbackk = "Good", Email = "ishara1@gmail.com" ,TelephoneNumber = 0779207296},
            new Models.Feedback { Id = 2, Name = "Harini", feedbackk = "Bad", Email = "harini@gmail.com" ,TelephoneNumber = 0779207296},
            new Models.Feedback{ Id = 3, Name = "Dimagi", feedbackk = "Not bad", Email ="dimagi@gmail.com",TelephoneNumber = 0779207296 },
            new Models.Feedback { Id = 4, Name = "Nawodi", feedbackk = "Excellent", Email = "nawodi@gmail.com" ,TelephoneNumber = 0779207296},
          
        };
    }
}
