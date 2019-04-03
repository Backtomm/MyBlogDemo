using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace My.Blog.Web.Controllers
{
    public class BlogController : Controller {
        DAL.BlogDAL dal = new DAL.BlogDAL();
        DAL.CategoryDAL cadal = new DAL.CategoryDAL();
        public IActionResult Index() {
                         
            return View();
        }

        /// <summary>
        /// 拼接条件
        /// </summary>
        /// <returns></returns>
        public string GetCond(string key, string para) {
            string cond = "1=1";
            if (!string.IsNullOrEmpty(key)) {
                key = Tool.GetSafeSQL(key);
                cond += $" and title like '%{key}%'";
            }
            if (!string.IsNullOrEmpty(para)) {
                para = Tool.GetSafeSQL(para);
                if (DateTime.TryParse(para, out DateTime d)) {
                    cond += $" and createdate like '{para}%'";
                } else {
                    cond += $" and categorynum = '{para}'";
                }
            }
            return cond;
        }

        /// <summary>
        /// 博客总数
        /// </summary>
        /// <returns></returns>
        public IActionResult GetBlogTotalCount(string key, string para) {
            int totalCount = dal.GetBlogTotalCount(GetCond(key, para));
            return Content(totalCount.ToString());
        }

        /// <summary>
        /// 取分页数据，返回JSON
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetBlogList(int pageIndex, int pageSize, string key, string para) {
            List<Model.Blog> list = dal.GetList("sort asc,id asc", pageIndex, pageSize, GetCond(key, para));
            ArrayList alist = new ArrayList();
            foreach (Model.Blog b in list) {
                alist.Add(new {
                    id = b.Id,
                    createDate = b.CreateDate.ToString("yyyy-MM-dd"),
                    title = b.Title,
                    body = Tool.StringTruncat(Tool.GetNoHTMLString(b.Body), 60, "......"),
                    categoryName = b.CategoryName,
                    categoryNum = b.CategoryNum
                });
            }
            return Json(alist);
        }

        public IActionResult Show(int id) {
            Model.Blog b = dal.GetModel(id);
            if (b == null)
                return Content("找不到该博客！");
            else {
                Model.Blog blog = new Model.Blog {
                    Id = b.Id,
                    CreateDate = b.CreateDate,
                    Title = b.Title,
                    Body = b.Body,
                    CategoryName = b.CategoryName,
                    CategoryNum = b.CategoryNum
                };
                return View(blog);
            }              
        }
    }
}