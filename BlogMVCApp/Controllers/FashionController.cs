using BlogMVCApp.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Index(int page = 1)
        {
            return View(await _blogDbContext.GetPaginatableArticlesDataAsync(page, _ItemPerPage));
        }
    }
}