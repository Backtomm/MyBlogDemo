using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using My.Blog.Web.Models;

namespace My.Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private IHostingEnvironment hostingEnv;
        public HomeController(IHostingEnvironment env) {
            this.hostingEnv = env;
        }

        public IActionResult Index()
        {
            int? id = HttpContext.Session.GetInt32("adminId");
            if (id != null)
                return View();
            else
                return Redirect("/Admin/Login/");

        }
        public IActionResult Top() { return View(); }
        public IActionResult Left() { return View(); }
        public IActionResult WelCome() { return View(); }

        ///// <summary>
        ///// layui编辑器上传图片功能
        ///// </summary>
        ///// <returns></returns>
        //public IActionResult ImgUpload() {
        //    //var file = Request.Form.Files[0];
        //    ////string path = @"C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\wwwroot\upload";
        //    ////FileStream fs = new FileStream(path, FileMode.Create);
        //    ////file.CopyTo(fs);
        //    //var m = new {
        //    //    code = 0,
        //    //    msg = "上传成功",
        //    //    data = new { src = "/upload/2.jpg", title = file.Name },
        //    //};
        //    //return Json(m);

        //    return View();
        //}
        /// <summary>
        /// layui在线编辑器里的上传图片功能
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ImgUpload() {
            #region 文件上传
            var imgFile = Request.Form.Files[0];
            if (imgFile != null && !string.IsNullOrEmpty(imgFile.FileName)) {
                long size = 0;
                string tempname = "";
                var filename = ContentDispositionHeaderValue
                                .Parse(imgFile.ContentDisposition)
                                .FileName
                                .Trim('"');
                var extname = filename.Substring(filename.LastIndexOf("."), filename.Length - filename.LastIndexOf("."));

                # region 判断图片大小
                long mb = imgFile.Length / 1024 / 1024;//mb
                if (mb > 5) {
                    return Json(new { code = 1, msg = "上传失败,图片大小超过5mb！", });
                }
                #endregion

                var filename1 = System.Guid.NewGuid().ToString().Substring(0, 6) + extname;
                tempname = filename1;
                var path = hostingEnv.WebRootPath;
                string dir = DateTime.Now.ToString("yyyyMMdd");
                if (!System.IO.Directory.Exists(hostingEnv.WebRootPath + $@"\upload\{dir}")) {
                    System.IO.Directory.CreateDirectory(hostingEnv.WebRootPath + $@"\upload\{dir}");
                }
                filename = hostingEnv.WebRootPath + $@"\upload\{dir}\{filename1}";
                size += imgFile.Length;
                using (FileStream fs = System.IO.File.Create(filename)) {
                    imgFile.CopyTo(fs);
                    fs.Flush();
                }
                return Json(new { code = 0, msg = "上传成功", data = new { src = $"/upload/{dir}/{filename1}", title = filename } });
            }
            return Json(new { code = 1, msg = "上传失败", });
            #endregion
        }
    }
}
