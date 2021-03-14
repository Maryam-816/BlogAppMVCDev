using BlogMVCApp.Areas.Admin.Data;
using BlogMVCApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private BlogDbContext _blogDbContext;
        private int _ItemPerPage;
        public AccountController()
        {
            _blogDbContext = new BlogDbContext();
            _ItemPerPage = 4;
        }
        // GET: Admin/Account
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _blogDbContext.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
                if (user == null)
                {
                    //fail
                    ModelState.AddModelError("", "Given email or password is wrong!");
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    //success
                }
            }
            return View();
        }
    }
}