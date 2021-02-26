using BlogMVCApp.Infastracture;
using BlogMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Index(int page = 1)
        {
            return View(_blogDbContext.GetPaginatableArticlesData(page, _ItemPerPage));
        }

        public ActionResult Categories()
        {
            return View(_blogDbContext.GetCategoriesData());
        }

        public ActionResult Tags()
        {
            return View(_blogDbContext.GetTagsData());
        }

        public ActionResult Travel()
        {
            return View();
        }
    }
}