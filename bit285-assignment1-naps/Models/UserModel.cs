﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace A1_Mod 
{
    public class UserModel
    {
    [Required(ErrorMessage ="Please enter your first name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please enter your last name")]
    public string LastName { get; set; }
    
    [EmailAddress]
    [Required(ErrorMessage = "Please enter your email")]
    [RegularExpression(".+\\@.+\\..+")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter a password between 8 and 20 characters long!")]
    [StringLength(18, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 20 characters long")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Please enter your program name")]
    public string Program { get; set; }

    [Required(ErrorMessage = "Please enter your birth year")]
    public string BirthYear { get; set; }

    [Required(ErrorMessage = "Please enter your favorite color")]
    public string FavColor { get; set; }
    }
}
