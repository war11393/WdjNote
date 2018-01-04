using System;
using System.Data;
using Interface;
using Model;

namespace SQLDAL
{
    public class UserOperateImpl : IUserOperate
    {
        public User FindUserByUsername(string name)
        {
            string sql = "select * from wdjuser where uname = '" + name + "'";
            DataTable dt = SQLOperate.QueryTable(sql);

            User u = null;
            if(dt.Rows.Count > 0)
            {
                u = new User(Convert.ToInt32(dt.Rows[0][0].ToString()),
                    dt.Rows[0][1].ToString(), dt.Rows[0][3].ToString());
                u.Upass = dt.Rows[0][2].ToString();
            }

            return u;
        }

        public User Login(string username, string password)
        {
            User u =  FindUserByUsername(username);

            if(u != null)
            {
                if(password != u.Upass.Trim())
                {
                    return null;
                } else
                {
                    u.Upass = "";
                    return u;
                }
            } else
            {
                return u;
            }
        }

        public User Regist(string username, string password, string nickname)
        {
            User u = FindUserByUsername(username);

            if(u != null)//用户名已被使用
            {
                return null;
            }
            else
            {
                string sql = "insert into wdjuser(uname,upass,unikename) values('" + username + "','" + password
                    + "','" + nickname + "')";
                SQLOperate.ExecuteSql(sql);
                u = FindUserByUsername(username);
                if(u != null)
                    u.Upass = "";
                return u;
            }
        }

        public int UpdateInfo(User u)
        {
            string sql = "update wdjuser set upass='" + u.Upass
                    + "',unikename='" + u.Unikename + "'";
            return SQLOperate.ExecuteSql(sql);
        }
    }
}
