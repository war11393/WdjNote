using System;
using System.IO;
using WdjNote.impl;

namespace WdjNote_01
{
    public class MyFile
    {
        string _path;//路径(包含分类名)
        string _name;//文件名
        string _content;//文件内容

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Content {
            get { return _content; }
            set { _content = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
    }

    class FileOperate : IFileOperate
    {
        //这里调用读取分类的方法将打开的文件中的分类值读出来，没有就返回0--默认分类
        public void OpenFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public string OpenFileToString(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line, s = "";
            while ((line = sr.ReadLine()) != null)
            {
                s += line;
            }
            return s;
        }

        //将文件类f保存
        public  void SaveFile(MyFile f)
        {
            if (Directory.Exists(f.Path) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(f.Path);
            }
            FileStream fs = new FileStream(f.Path + "\\" + f.Name, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(f.Content);
            sw.Flush();
            sw.Close(); fs.Close();
        }

        //修改文件分类
        public  void UpdateFileCategory(MyFile f, string newpath)
        {
            File.Move(f.Name, newpath);
        }
    }
}
