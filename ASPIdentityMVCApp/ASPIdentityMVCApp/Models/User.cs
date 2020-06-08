using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPIdentityMVCApp.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Username")]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Username is too short")]
        [ScaffoldColumn(true)]
        public string Name { get; set; }

        [Display(Name = "Enter password")]
        [MinLength(5, ErrorMessage = "Password is too short")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm your password")]
        [Compare("password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}