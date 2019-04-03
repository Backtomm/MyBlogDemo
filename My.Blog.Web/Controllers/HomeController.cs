using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My.Blog.Web.Models;

namespace My.Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string number) {
            DAL.CategoryDAL cadal = new DAL.CategoryDAL();
            DAL.BlogDAL dal = new DAL.BlogDAL();             
            ViewBag.calist = cadal.GetList("");
            ViewBag.datelist = dal.GetCreatDateGroup();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
