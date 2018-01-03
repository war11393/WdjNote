using System;
using System.Collections.Generic;

namespace Control
{
    public class CategoryOperate
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

        //显示现有分类
        public string ShowCategory(string path)
        {
            int i = 1;
            foreach (string d in notelist)
           {
               System.Console.WriteLine(i+"-->"+d);
               i++;
           }
            System.Console.WriteLine(i + "-->" + "新建笔记");
            int id = int.Parse(Console.ReadLine());
            if (id == i)
            {
                System.Console.WriteLine("请输入要创建的分类名：");
                string p = System.Console.ReadLine();
                path = path+ p;
                notelist.Add(p);
            }else if(id>i)
            {
                System.Console.WriteLine("输入错误");
                return path + notelist[0];
            }else
            {
                path = path + notelist[id - 1];
            }
            return path;
        }
    }
}
