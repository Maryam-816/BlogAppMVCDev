using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("myblogDbConnection")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Catigorises { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

    }
}