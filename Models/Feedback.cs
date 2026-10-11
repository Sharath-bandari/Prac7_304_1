
using System.ComponentModel.DataAnnotations;

namespace Feedback_Management.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Feedback is required")]
        public string Message { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a rating")]
        [Range(1, 5, ErrorMessage = "Please select a rating")]
        public int Rating { get; set; }
    }
}
