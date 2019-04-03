using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace My.Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        DAL.BlogDAL dal = new DAL.BlogDAL();
        DAL.CategoryDAL cadal = new DAL.CategoryDAL();
        public IActionResult Index()
        {
            ViewBag.calist = cadal.GetList("");
            return View();
        }

        /// <summary>
        /// 拼接条件
        /// </summary>
        /// <returns></returns>
        public string GetCond(string key, string start, string end, string number) {
            string cond = "1=1";
            if (!string.IsNullOrEmpty(key)) {
                key = Tool.GetSafeSQL(key);
                cond += $" and title like '%{key}%'";
            }
            if (!string.IsNullOrEmpty(start)) {
                if (DateTime.TryParse(start, out DateTime d)) {
                    cond += $" and createdate >= '{start}'";
                }               
            }
            if (!string.IsNullOrEmpty(end)) {
                if (DateTime.TryParse(start, out DateTime d)) {
                    cond += $" and createdate <= '{end}'";
                }
            }
            if (!string.IsNullOrEmpty(number)) {
                number = Tool.GetSafeSQL(number);
                cond += $" and categorynum = '{number}'";
            }
            return cond;
        }

        /// <summary>
        /// 博客总数
        /// </summary>
        /// <returns></returns>
        public IActionResult GetBlogTotalCount(string key,string start,string end,string number) {
            int totalCount = dal.GetBlogTotalCount(GetCond(key,start,end,number));
            return Content(totalCount.ToString());
        }

        /// <summary>
        /// 取分页数据，返回JSON
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetBlogList(int pageIndex,int pageSize, string key, string start, string end, string number) {
            List<Model.Blog> list = dal.GetList("sort asc,id asc",pageIndex,pageSize, GetCond(key, start, end, number));
            ArrayList alist = new ArrayList();
            foreach (Model.Blog b in list) {
                alist.Add(new {
                    id = b.Id,
                    createDate = b.CreateDate.ToString("yyyy-MM-dd hh:mm"),
                    title = b.Title,
                    visitNum = b.VisitNum,
                    categoryName = b.CategoryName,
                    sort = b.Sort
                });
            }
            return Json(alist);
        }

        public IActionResult Add(int? id) {
            ViewBag.calist = cadal.GetList("");
            Model.Blog m= new Model.Blog();
            if (id != null) {
                m = dal.GetModel(id.Value);
            }
            return View(m);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Add(Model.Blog m) {
            Model.Category ca = cadal.GetModelByNumber(m.CategoryNum);
            if (ca != null) {
                m.CategoryName = ca.CategoryName;
            }
            if (m.Id == 0) {
                //新增
                dal.Insert(m);
            } else {
                //修改
                dal.Update(m);
            }
            return Redirect("/Admin/Blog/Index");
        }

        [HttpPost]
        public IActionResult Del(int id) {
            bool result = dal.Delete(id);
            if (result) return Content("删除成功");
            return Content("删除失败！");
        }

    }
}