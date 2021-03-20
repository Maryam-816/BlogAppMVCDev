using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Areas.Admin.Data
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is not given")]
        [EmailAddress(ErrorMessage = "Your Email is invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is not given")]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "Your Password must be least 8 and maximum 20 characters")]
        public string Password { get; set; }
    }
}