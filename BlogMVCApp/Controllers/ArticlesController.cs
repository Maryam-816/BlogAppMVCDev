﻿using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class ArticlesController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _ItemPerPage;

        public ArticlesController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _ItemPerPage = 4;
        }
        // GET: Articles
        [HttpGet]
        [ActionName("Details")]
        public async Task<ActionResult> DetailsAsync(int id)
        {
            var article = await _blogDbContext.Articles.FindAsync(id);

            ArticleDetailsModel model = new ArticleDetailsModel
            {
                Id = article.Id,
                Title = article.Title,
                ImagePath = article.ImagePath,
                Description = article.Description,
                ShortDescription = article.ShortDescription,
                Author = new AuthorModel
                {
                    UserId = article.Author.UserId,
                    Description = article.Author.Description,
                    Profileicture = article.Author.ProfilePicture,
                    Name = article.Author.Name,
                    Surname = article.Author.Surname
                },
                Tags = article.Tags.Select(t => new TagModel 
                { 
                    Id = t.Id,
                    Name = t.Name
                }).ToList(),
            };

            if (article == null)
                return RedirectToAction("Error", "Home");

            return View(model);
        }
    }
}