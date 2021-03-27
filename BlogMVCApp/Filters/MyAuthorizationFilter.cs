using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVCApp.Filters
{
    public class MyAuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
        private readonly string _url;
        public MyAuthorizationFilter(string url)
        {
            this._url = url;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["userInfo"] == null)
                filterContext.HttpContext.Response.Redirect(this._url);
        }
    }
}