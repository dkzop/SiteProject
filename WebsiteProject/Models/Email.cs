using System.ComponentModel.DataAnnotations;

namespace WebsiteProject.Models
{
    public class ForgotPasswordModel
    {
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}