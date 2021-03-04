using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Data
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 80, MinimumLength = 2)]
        public string Title { get; set; }

        public Author Author { get; set; }

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
    }
}