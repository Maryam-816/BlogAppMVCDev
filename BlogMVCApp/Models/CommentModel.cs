using BlogMVCApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(20)]
        public string Email { get; set; }
        public string WebSite { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime CommentDate { get; set; }
        public int ArticleId { get; set; }
        public virtual User User { get; set; }
        public virtual Article Article { get; set; }
    }
}