using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLDAL
{
    class SQLOperate
    {
        static SqlConnection conn = Connection.GetConn();

        /// <summary>
        /// 提交查询语句并以数据表返回
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <returns>查询得到的数据表</returns>
        public static DataTable QueryTable(string sql)
        {
            DataTable dt = null;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();  
                cmd.CommandText = sql;
                dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            } catch(Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        /// <summary>
        /// 执行简单sql语句
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteSql(string sql)
        {
            int i = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return i;
        }
    }
}
