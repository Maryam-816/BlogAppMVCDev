using System;
using BlogMVCApp.Migrations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Data
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50, MinimumLength =2)]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        [Required]
        public string ControllerName { get; set; }

        [Required]
        public byte Order { get; set; }
        public string ActionName { get; set; }

        public Menu()
        {
            Articles = new HashSet<Article>();
        }
    }
}