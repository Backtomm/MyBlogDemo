using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace My.Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username,string password)
        {
            username = Tool.GetSafeSQL(username);
            password = Tool.MD5Hash(password);
            DAL.AdminDAL dal = new DAL.AdminDAL();
            Model.Admin admin = dal.GetModel(username, password);
            if (admin == null) {
                return Content("用户名或密码错误");
            } else {
                HttpContext.Session.SetInt32("adminId",admin.Id);
                HttpContext.Session.SetString("adminUsername",admin.UserName);
                return Redirect("/Admin/Home/Index");
            }
        }

        public IActionResult Register() {

            return View();
        }

    }
}