
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My.Blog.DAL {
    /// <summary>
    /// 管理员表的数据库操作类
    /// </summary>
    public class AdminDAL {

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Admin GetModel(string username,string password) {
            using (var connection = ConnectionFactory.GetConnection()) {
                var m = connection.Query<Model.Admin>("select * from admin where username = @username and password = @password", 
                    new { username = username , password = password }).FirstOrDefault();

                return m;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="m"></param>
        public bool Update(Model.Admin m) {
            using (var connection = ConnectionFactory.GetConnection()) {
                int res = connection.Execute(@"UPDATE blog set 
                                                             username=@UserName
                                                            ,password=@Password
                                                            ,remark=@remark                                                           
                                                            where id = @Id", m);
                if(res > 0) {
                    return true;
                }
                return false;
            }
        }

    }
}
