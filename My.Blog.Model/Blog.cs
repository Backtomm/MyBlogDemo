using System;
using System.Collections.Generic;
using System.Text;

namespace My.Blog.Model {
    /// <summary>
    /// 博客表
    /// </summary>
    public class Blog {
        /// <summary>
        /// 主键自增
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// 内容md
        /// </summary>
        public string Body_md { get; set; }
        /// <summary>
        /// 访问量
        /// </summary>
        public int VisitNum { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public string CategoryNum { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
