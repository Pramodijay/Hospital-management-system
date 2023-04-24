using System.Reflection;
using Feedback.Data;
using Feedback.Models;

namespace Feedback.Services
{
    public class FeedbackService : IFeedbackService
    {
        public List<Models.Feedback> GetFeedbacks()
        {
            return FeedbackMockDataService.Feedbacks;
        }

        public Models.Feedback? GetFeedback(int id)
        {
            return FeedbackMockDataService.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public Models.Feedback? AddFeedback(Models.Feedback feedback)
        {
            FeedbackMockDataService.Feedbacks.Add(feedback);
            return feedback;
        }

        public Models.Feedback? UpdateFeedback(Models.Feedback feedback)
        {
            Models.Feedback selectedFeedback = FeedbackMockDataService.Feedbacks.FirstOrDefault(x => x.Id == feedback.Id);
            if (selectedFeedback != null)
            {
                selectedFeedback.feedbackk = feedback.feedbackk;
                selectedFeedback.Email = feedback.Email;
                selectedFeedback.TelephoneNumber = feedback.TelephoneNumber;
                selectedFeedback.Name = feedback.Name;
               


                return selectedFeedback;
            }

            return selectedFeedback;
        }

        public bool? DeleteFeedback(int id)
        {
            Models.Feedback selectedFeedback = FeedbackMockDataService.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (selectedFeedback != null)
            {
                FeedbackMockDataService.Feedbacks.Remove(selectedFeedback);
                return true;
            }
            return false;
        }
    }
}
