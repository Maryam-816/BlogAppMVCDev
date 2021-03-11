using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class ArticleDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public AuthorModel Author { get; set; }
        public List<TagModel> Tags { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}