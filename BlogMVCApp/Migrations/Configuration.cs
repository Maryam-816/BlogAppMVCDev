namespace BlogMVCApp.Migrations
{
    using BlogMVCApp.Models;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogMVCApp.Data.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BlogMVCApp.Data.BlogDbContext context)
        {
                context.Menus.AddOrUpdate
                (
                    new Models.Menu
                    {
                        Id = 1,
                        IsActive = true,
                        Name = "Travel",
                        ControllerName = "Home",
                        ActionName = "Travel",
                        Order = 1
                    },
                     new Models.Menu
                     {
                         Id = 2,
                         IsActive = true,
                         Name = "Fashion",
                         ControllerName = "Home",
                         ActionName = "Travel",
                         Order = 2
                     },
                      new Models.Menu
                      {
                          Id = 3,
                        IsActive = true,
                          Name = "About",
                          ControllerName = "Home",
                          ActionName = "Travel",
                          Order = 3
                      },
                       new Models.Menu
                       {
                           Id = 4,
                           IsActive = true,
                           Name = "Contact",
                           ControllerName = "Home",
                           ActionName = "Travel",
                           Order = 4
                       }
                );

            string email = ConfigurationManager.AppSettings["email"],
                    username = ConfigurationManager.AppSettings["username"],
                     password = ConfigurationManager.AppSettings["password"];

            context.Users.AddOrUpdate(new User
            {
                Id = 1,
                IsActive = true,
                IsAuthor = true,
                Email = email,
                Password = password,
                UserName = username
            });

            context.Authors.AddOrUpdate(new Author
            {
                UserId = 1,
                Id = 1
            });

            //context.Articles.AddOrUpdate(new Article
            //{
            //    Id = 1,
            //    AuthorId = 1,
            //    ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
            //    Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia. A small river named Duden flows by their place and supplies it with the necessary regelialia.",
            //    PublishTime = DateTime.Now,
            //    WrittenTime = DateTime.Now,
            //    Title = "A Loving Heart is the Truest Wisdom",
            //    ImagePath = "image_1.jpg",
            //    MenuId = 1,
            //},
            //new Article
            //{
            //    Id = 2,
            //    AuthorId = 1,
            //    ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
            //    Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia. A small river named Duden flows by their place and supplies it with the necessary regelialia.",
            //    PublishTime = DateTime.Now,
            //    WrittenTime = DateTime.Now,
            //    Title = "Great Things Never Came from Comfort Zone",
            //    ImagePath = "image_2.jpg",
            //    MenuId = 1,
            //},
            //new Article
            //{
            //    Id = 3,
            //    AuthorId = 1,
            //    ShortDescription = "A small river named Duden flows by their place and supplies it with the necessary regelialia.",
            //    Description = "A small river named Duden flows by their place and supplies it with the necessary regelialia. A small river named Duden flows by their place and supplies it with the necessary regelialia.",
            //    PublishTime = DateTime.Now,
            //    WrittenTime = DateTime.Now,
            //    Title = "You Can't Blame Gravity for Falling in Love",
            //    ImagePath = "image_3.jpg",
            //    MenuId = 1,
            //}
            //);

            context.Catigorises.AddOrUpdate(
            new Category
            {
                Id = 1,
                Name = "Fashion"
            },
            new Category
            {
                Id = 2,
                Name = "Technology"
            },
            new Category
            {
                Id = 3,
                Name = "Travel"
            },
            new Category
            {
                Id = 4,
                Name = "Food"
            },
            new Category
            {
                Id = 5,
                Name = "Photography"
            },
            new Category
            {
                Id = 6,
                Name = "LifiStyle"
            });

            //context.Comments.AddOrUpdate(new Comment
            //{

            //});

            //context.Tags.AddOrUpdate(new Tag { })
        }
    }
}
