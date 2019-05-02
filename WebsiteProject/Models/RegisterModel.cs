using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        public string Email { get; set; }

        public string ReturnUrl { get; set; }
    }
}