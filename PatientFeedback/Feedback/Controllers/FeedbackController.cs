using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Feedback.Data;
using Feedback.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Feedback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController (IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService ?? throw new ArgumentNullException(nameof(feedbackService));
        }


        /// <summary>
        /// Get all feedback
        /// </summary>
        /// <returns>return the list of feedbacks</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_feedbackService.GetFeedbacks());
        }

        /// <summary>
        /// Get feedback by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the feedback with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _feedbackService.GetFeedback(id) != null ? Ok(_feedbackService.GetFeedback(id)) : NoContent();
        }

        /// <summary>
        /// Add feedback
        /// </summary>
        /// <param name="feedback"></param>
        /// <returns>Return the added feedback</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Feedback feedback)
        {
            return Ok(_feedbackService.AddFeedback(feedback));
        }

        /// <summary>
        /// Update the feedback
        /// </summary>
        /// <param name="feedback"></param>
        /// <returns>Return the updated feedback</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Feedback feedback)
        {
            return Ok(_feedbackService.UpdateFeedback(feedback));
        }

        /// <summary>
        /// Delete the feedbackwith the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _feedbackService.DeleteFeedback(id);

            return result.HasValue & result == true ? Ok($"feedbackk with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the feedback with ID:{id}.");
        }
    }
}


