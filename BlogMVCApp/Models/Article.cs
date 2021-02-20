using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 6)]
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishTime { get; set; }
        public DateTime WrittenTime { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        public uint ViewCount { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public ICollection<Category> Catigories { get; set; }

        public Menu Menu { get; set; }

        public int MenuId { get; set; }

        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
            Catigories = new HashSet<Category>();
        }
    }
}