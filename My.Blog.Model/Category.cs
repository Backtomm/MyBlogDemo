using System;
using System.Collections.Generic;
using System.Text;

namespace My.Blog.Model {
    /// <summary>
    /// 分类表
    /// </summary>
    public class Category {

        /// <summary>
        /// 主键自增
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 父级编号
        /// </summary>
        public string PNumber{ get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


    }
}
