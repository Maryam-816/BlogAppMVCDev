using BlogMVCApp.Areas.Admin.Data;
using BlogMVCApp.Infastracture;
using BlogMVCApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _blogDbContext.Users.GetUserAsync(model);
                if (user == null)
                {
                    ModelState.AddModelError("", "This user doesn't exist");
                    return View();
                }
                else
                    Session.Add("userInfo", user.Email);
                    return RedirectToAction(nameof(Success));
            }
            return RedirectToAction(nameof(Error));
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Success()
        {
            if (Session["userInfo"] == null)
                return RedirectToAction(nameof(Login));

            else
                return View();

        }
    }
}