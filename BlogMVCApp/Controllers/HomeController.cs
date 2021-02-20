using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
   
    public class HomeController : Controller
    {
        private BlogMVCApp.Data.BlogDbContext _blogDbContext;

        public HomeController()
        {
            _blogDbContext = new Data.BlogDbContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(_blogDbContext.Articles.ToList());
        }

        public ActionResult Travel()
        {
            return View();
        }
    }
}