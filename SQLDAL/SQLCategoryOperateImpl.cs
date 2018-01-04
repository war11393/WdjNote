using System.Collections.Generic;
using Interface;
using Model;
using System.Data;
using System;

namespace SQLDAL
{
    public class SQLCategoryOperateImpl : ISQLCategoryOperate
    {
        public void AddCategory(int uno, string name)
        {
            string sql = "insert into cate values(null, " + uno + "," + name + ")";
            SQLOperate.ExecuteSql(sql);
        }

        public void DeleteCategory(int cno)
        {
            string sql = "delete cate where cno = " + cno;
            SQLOperate.ExecuteSql(sql);
        }

        public List<Category> GetCategory(int uno)
        {
            string sql = "select * from cate where cuno = " + uno;
            DataTable dt = SQLOperate.QueryTable(sql);

            List<Category> clist = new List<Category>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Category c = new Category(Convert.ToInt32(dt.Rows[i][0].ToString()),
                    Convert.ToInt32(dt.Rows[i][1].ToString()),
                    dt.Rows[i][2].ToString());
                clist.Add(c);
            }

            return clist;
        }
    }
}
