using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class ArticleTravelModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime WrittenTime { get; set; }
        public string ImagePath { get; set; }
        public string ShortDescription { get; set; }
        public int AuthorPicture { get; set; }
        public string AuthorName { get; set; }
        public int ViewCount { get; set; }
        public int CommentsCount { get; set; }
    }
}