using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace My.Blog.DAL
{
    /// <summary>
    /// 数据库连接工厂
    /// </summary>
    public class ConnectionFactory{
        //创建连接对象  
        public static DbConnection GetConnection() {

            var connection = new MySqlConnection("Database=myblog;Data Source=localhost;User Id=root;Password=admin;CharSet=utf8;port=3306");

            connection.Open();

            return connection;
        }
    }
}
