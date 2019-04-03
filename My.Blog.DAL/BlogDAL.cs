using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My.Blog.DAL {
    ///sql语句前加@可以防止换行后C#报错,可以取消该字符串转义
    /// <summary>
    /// 博客表的数据库操作类
    /// </summary>
    public class BlogDAL {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Insert(Model.Blog m) {
            using (var connection = ConnectionFactory.GetConnection()) {
                int resid = connection.Query<int>(
                        @"INSERT INTO blog(title,body,body_md,visitnum,categorynum,categoryname,remark,sort) 
                            values(@Title,@Body,@Body_md,@VisitNum,@CategoryNum,@CategoryName,@remark,@Sort);SELECT @@IDENTITY;",
                        m).FirstOrDefault();
                return resid;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id) {
            using (var connection = ConnectionFactory.GetConnection()) {
               int res = connection.Execute(@"DELETE FROM blog where id = @id",new { id = id});
                if (res > 0) {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="cond"></param>
        /// <returns></returns>
        public List<Model.Blog> GetList(string cond) {
            using (var connection = ConnectionFactory.GetConnection()) {
                string sql = "select * from blog ";
                if (!string.IsNullOrEmpty(cond)) {
                    sql += $" where {cond}";
                }
                var list = connection.Query<Model.Blog>(sql).ToList();
                return list;
            }
        }

        /// <summary>
        /// 根据id获取博客model
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Blog GetModel(int id) {
            using (var connection = ConnectionFactory.GetConnection()) {
                var m = connection.Query<Model.Blog>("select * from blog where id = @Id", new { id = id}).FirstOrDefault();
                return m;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="m"></param>
        public bool Update(Model.Blog m) {
            using (var connection = ConnectionFactory.GetConnection()) {
                int res = connection.Execute(@"UPDATE blog set 
                                                             title=@Title
                                                            ,body=@Body
                                                            ,body_md=@Body_md
                                                            ,visitnum=@VisitNum
                                                            ,categorynum=@CategoryNum
                                                            ,categoryname=@CategoryName
                                                            ,remark=@remark
                                                            ,sort=@Sort 
                                                            where id = @Id", m);
                if(res > 0) {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 根据条件获取博客总数
        /// </summary>
        /// <returns></returns>
        public int GetBlogTotalCount(string cond) {
            string sql = "select count(1) from blog";
            if (!string.IsNullOrEmpty(cond)) {
                cond = " where " + cond;
                sql += cond;
            }
            
            using (var connection = ConnectionFactory.GetConnection()) {
                int res = connection.ExecuteScalar<int>(sql);
                return res;
            }
        }

        /// <summary>
        /// 分页获取博客列表
        /// </summary>
        /// <param name="orderstr"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="strwhere"></param>
        /// <returns></returns>
        public List<Model.Blog> GetList(string orderstr,int pageIndex,int pageSize,string strwhere) {
            if (!string.IsNullOrEmpty(strwhere)) {
                strwhere = " where " + strwhere;
            }           
            string sql = string.Format($"select * from blog {strwhere} order by {orderstr} limit {(pageIndex - 1) * pageSize},{pageSize} ");
            using (var connection = ConnectionFactory.GetConnection()) {               
                var list = connection.Query<Model.Blog>(sql).ToList();
                return list;
            }
        }

        /// <summary>
        /// 获取创建博客的月份组，以及该月份博客总数
        /// </summary>
        /// <returns></returns>
        public List<string> GetCreatDateGroup() {
            string sql = string.Format("select DATE_FORMAT(createdate,'%Y-%m') d,count(1) from blog group by d order by d desc");
            using (var connection = ConnectionFactory.GetConnection()) {

                var list = connection.Query<string>(sql).ToList();

                return list;
            }
        }
    }
}
