using BlogMVCApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Controllers
{
    public class MenusController : Controller
    {
        private readonly BlogDbContext _blogDbContext;

        public MenusController()
        {
            _blogDbContext = new BlogDbContext();
        }

        public PartialViewResult AllMenus()
        {
            var menus = _blogDbContext.Menus.Where(m => m.IsActive == true).ToList();
            return PartialView(menus);
        }
    }
}