using Dapper;
using My.Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My.Blog.DAL {
    /// <summary>
    /// 分类表的数据库操作类
    /// </summary>
    public class CategoryDAL {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int Insert(Model.Category m) {
            using (var connection = ConnectionFactory.GetConnection()) {
                int resid = connection.Query<int>(
                        @"INSERT INTO category(categoryname,number,pnumber,remark) values(@categoryname,@number,@pnumber,@remark);SELECT @@IDENTITY;",
                        m).FirstOrDefault();
                return resid;
            }
        }

        /// <summary>
        /// 根据编号取实体类
        /// </summary>
        /// <returns></returns>
        public Category GetModelByNumber(string caNumber) {
            using (var connection = ConnectionFactory.GetConnection()) {
                string sql = "select * from category where number = @number";
                var m = connection.Query<Model.Category>(sql,new { number = caNumber }).FirstOrDefault();
                return m;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id) {
            using (var connection = ConnectionFactory.GetConnection()) {
               int res = connection.Execute(@"DELETE FROM category where id = @id",new { id = id});
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
        public List<Model.Category> GetList(string cond) {
            using (var connection = ConnectionFactory.GetConnection()) {
                string sql = "select * from category";
                if (!string.IsNullOrEmpty(cond)) {
                    sql += $"where{cond}";
                }
                var list = connection.Query<Model.Category>(sql).ToList();
                return list;
            }
        }

        public Model.Category GetModel(int id) {
            using (var connection = ConnectionFactory.GetConnection()) {
                var m = connection.Query<Model.Category>("select * from category where id = @Id", new { id = id}).FirstOrDefault();
                return m;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="m"></param>
        public bool Update(Model.Category m) {
            using (var connection = ConnectionFactory.GetConnection()) {
                int res = connection.Execute(@"UPDATE category set 
                                        categoryname = @CategoryName,number = @Number,pnumber = @PNumber,remark = @Remark where id = @Id",m);
                if(res > 0) {
                    return true;
                }
                return false;
            }
        }

    }
}
