using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class ArticlePopularModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishTime { get; set; }
        public string ImagePath { get; set; }
        public string AuthorName { get; set; }
        public int CommentsCount { get; set; }
    }
}