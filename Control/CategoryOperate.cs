using System;
using System.Collections.Generic;
using Interface;
using System.IO;
namespace Control
{
    public class CategoryOperate:ICategoryOperate
    {
        public List<string> notelist;

        public CategoryOperate()
        {
            Init();
        }
        public void Init()
        {
            notelist = new List<string>();
            notelist.Add("我的笔记");
            notelist.Add("其他");
        }
        //添加分类
        public void AddCategory(string name,string username)
        {         
            string path = "D://WdjNote//" + username +"//" + name;
            if(Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        //删除分类
        public void DeleteCategory(string name,string username)
        {
            //http://blog.csdn.net/dongzhe8/article/details/46646215
            string path="D://WdjNote//"+username+"//"+name;
            System.IO.Directory.Delete(path, true);// 就可以删除了注意C:/Temp后面没有/  
        }
        //查询得到所有分类
        public List<string> GetCategory(string username)
        {
            //http://bbs.csdn.net/topics/60198846
            List<string> a = new List<string>();
          //  ArrayList a = new ArrayList();
            DirectoryInfo d = new DirectoryInfo("D://WdjNote//"+username+"//");

            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                a.Add(fi.Name);
            }

            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                a.Add(di.Name);


            }
            return a;
        }

        //通过用户指定的根目录返回分类列表
        public List<string> GetCategoryByUser(string path)
        {
            throw new NotImplementedException();
        }
    }
}
