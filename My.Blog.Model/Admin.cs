using System;
using System.Collections.Generic;
using System.Text;

namespace My.Blog.Model {
    /// <summary>
    /// 管理员表
    /// </summary>
    public class Admin {

        /// <summary>
        /// 主键自增
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


    }
}
