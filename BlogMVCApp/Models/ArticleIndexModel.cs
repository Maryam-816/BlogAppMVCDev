using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class ArticleIndexModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Title { get; set; }
        public DateTime PublishTime { get; set; }
        public string ImagePath { get; set; }

        public string ShortDescription { get; set; }

        public string AuthorName { get; set; }

        public uint ViewCount { get; set; }

        public IEnumerable<CategoryModel> Catigories { get; set; }

        public int CommentsCount { get; set; }
    }
}