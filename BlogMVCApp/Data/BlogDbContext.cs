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
        public BlogDbContext():base("myblogDbConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Catigorises { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Author> Authors { get; set; }


    }
}