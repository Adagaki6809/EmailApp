using System.ComponentModel.DataAnnotations;

namespace EmailApp.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}