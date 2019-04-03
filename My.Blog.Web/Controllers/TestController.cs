using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace My.Blog.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            string str = "";
            Random rd = new Random();
            DAL.CategoryDAL cadal = new DAL.CategoryDAL();
            DAL.BlogDAL bdal = new DAL.BlogDAL();

            var calist = cadal.GetList("");

            for (int i = 0;i<100;i++) {
                string title = $"英雄联盟比赛{i}";
                string body = title + "的内容";
                Model.Category m = calist[rd.Next(0,calist.Count())];
                string number = m.Number;
                string categoryName = m.CategoryName;
                bdal.Insert(new Model.Blog() { Title = title,Body = body,CategoryName = categoryName,CategoryNum = number });
            }
            str = "添加100条数据";
            //str += "新增的insert方法返回的值" + cadal.Insert(new Model.Category { CategoryName = "newca"}) + "<hr/>";
           
            //str += "删除ID=11的数据值"+ cadal.Delete(11) + "<hr/>";

            //Model.Category ca = cadal.GetModel(10);
            
            //if (ca != null) {
            //    ca.CategoryName = "asadad";
            //    str += "更新ID=10的数据值" + cadal.Update(ca) + "<hr/>";
            //}

            //List<Model.Category> list = cadal.GetList("");
            //foreach(var item in list){
            //    str += $"<div>分类ID：{item.Id},分类名称：{item.CategoryName}</div>";
            //}
            return Content(str);
        }
    }
}