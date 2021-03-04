using BlogMVCApp.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class TravelController : Controller
    {
        private Data.BlogDbContext _blogDbContext;
        private int _ItemPerPage;

        public TravelController()
        {
            _blogDbContext = new Data.BlogDbContext();
            _ItemPerPage = 4;
        }
        // GET: Travel
        public ActionResult Index(int page = 1)
        {
            return View(_blogDbContext.GetPaginatableTravelArticlesData(page, _ItemPerPage));
        }
    }
    
}