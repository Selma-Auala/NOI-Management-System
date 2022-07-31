﻿using System.ComponentModel.DataAnnotations;

namespace NOI_System_API.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    } 
}
