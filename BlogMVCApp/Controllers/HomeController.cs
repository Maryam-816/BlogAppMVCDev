using BlogMVCApp.Infastracture;
using BlogMVCApp.Migrations;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
   
    public class HomeController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _ItemPerPage;

        public HomeController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _ItemPerPage = 4;
        }
        // GET: Home
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync(int page = 1)
        {
            return  View(await _blogDbContext.GetPaginatableArticlesDataAsync(page, _ItemPerPage));
        }

        public ActionResult Categories()
        {
            return View(_blogDbContext.GetCategoriesData().ToList());
        }

        public ActionResult Tags()
        {
            return View(_blogDbContext.GetTagsData().ToList());
        }

        public ActionResult PopularArticle()
        {
            return View(_blogDbContext.GetPopularArticlesData().ToList());
        }

        public ActionResult Travel()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}