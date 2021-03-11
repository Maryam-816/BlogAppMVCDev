using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Data
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 6)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string ProfilePicture { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool IsAuthor { get; set; }
    }
}