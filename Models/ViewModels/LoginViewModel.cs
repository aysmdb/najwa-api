using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Najwa_Api.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName {get;set;}

        [Required]
        public string Password {get;set;}
    }

    public class RegisterViewModel
    {
        [Required]
        public string UserName {get;set;}

        [Required]
        [StringLength(100, ErrorMessage = "PASSWORD_MIN_LENGTH", MinimumLength = 6)]
        public string Password {get;set;}

        [Required]
        public string PhoneNumber {get;set;}
    }
}