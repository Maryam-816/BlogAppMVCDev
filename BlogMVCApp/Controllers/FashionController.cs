using BlogMVCApp.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class FashionController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _ItemPerPage;

        public FashionController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _ItemPerPage = 4;
        }
        // GET: Fashion
        public ActionResult Index(int page = 1)
        {
            return View(_blogDbContext.GetPaginatableArticlesData(page, _ItemPerPage));
        }
    }
}