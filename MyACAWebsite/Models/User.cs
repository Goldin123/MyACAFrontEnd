using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyACAWebsite.Models
{
    public class User
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Enter First Name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter Last Name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Email Address.")]
        [EmailAddress(ErrorMessage ="Enter Valid Email Address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Passwword.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password.")]
        [Compare("Password",ErrorMessage ="Password Doesn't Macth")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Enter Age.")]
        [Range(1, 30, ErrorMessage = "Only positive number allowed")]
        public int Age { get; set; }
        public string Grade { get; set; }
        [Required(ErrorMessage = "Enter SA ID number.")]
        [MaxLength(13)]
        public string SAID { get; set; }
    }

    public class Login
    {
        public int? ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
