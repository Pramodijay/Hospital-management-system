namespace Feedback.Services
{
    public interface IFeedbackService
    {
        List<Models.Feedback> GetFeedbacks();
        Models.Feedback? GetFeedback(int id);
        Models.Feedback? AddFeedback(Models.Feedback feedback);
        Models.Feedback? UpdateFeedback(Models.Feedback feedback);
        bool? DeleteFeedback(int id);
    }
}
