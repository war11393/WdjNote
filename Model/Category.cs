<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
=======
﻿using System.Collections.Generic;
>>>>>>> 79a961b16b97b3a97aaceabfaf4f5ddc10b55aae

namespace Model
{
    public class Category
    {
<<<<<<< HEAD
        public List<string> notelist;

        public Category()
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
=======
        int _cno;
        int _cuno;
        string _cname;
        List<SFile> _fileList;

        public Category(int cuno, string cname)
        {
            _cuno = cuno;
            _cname = cname;
        }

        public Category(int cno, int cuno, string cname)
        {
            _cno = cno;
            _cuno = cuno;
            _cname = cname;
        }

        public int Cno
        {
            get
            {
                return _cno;
            }

            set
            {
                _cno = value;
            }
        }
        public int Cuno
        {
            get
            {
                return _cuno;
            }

            set
            {
                _cuno = value;
            }
        }
        public string Cname
        {
            get
            {
                return _cname;
            }

            set
            {
                _cname = value;
            }
        }
        public List<SFile> FileList
        {
            get
            {
                return _fileList;
            }

            set
            {
                _fileList = value;
            }
>>>>>>> 79a961b16b97b3a97aaceabfaf4f5ddc10b55aae
        }
    }
}
