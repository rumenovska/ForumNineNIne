﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ForumNineNine.WebModels.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Please enter email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password")]
        public string ConfirmPassword { get; set; }
    }
}
