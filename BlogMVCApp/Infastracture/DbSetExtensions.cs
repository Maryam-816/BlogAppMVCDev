using BlogMVCApp.Areas.Admin.Data;
using BlogMVCApp.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogMVCApp.Infastracture
{
    public static class DbSetExtensions
    {
        public async static Task<User> GetUserAsync(this DbSet<User> _users,  LoginModel loginModel)
        {
            if (!_users.Any(x => x.Email == loginModel.Email && x.Password == loginModel.Password))
                return null;
            else
                return await _users.Where(x => x.Email == loginModel.Email && x.Password == loginModel.Password).SingleOrDefaultAsync();




        }
    }
}