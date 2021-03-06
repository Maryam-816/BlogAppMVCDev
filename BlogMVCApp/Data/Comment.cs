using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Data
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 1)]
        public string Text { get; set; }

        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}