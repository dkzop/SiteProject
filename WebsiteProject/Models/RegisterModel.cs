using System.ComponentModel.DataAnnotations;

namespace WebsiteProject.Models
{
    public partial class RegisterModel
    {
        [Display(Name = "Username")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool Success { get; set; }
        
    }
}