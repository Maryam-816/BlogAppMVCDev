using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        public ICollection<Article> Articles { get; set; }

        public Author()
        {
            Articles = new HashSet<Article>();
        }
    }
}