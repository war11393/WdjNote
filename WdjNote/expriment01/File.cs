using System;
using System.IO;

namespace WdjNote_01
{
    class MyFile
    {
        string _name;//路径(包含分类名)+文件名
        string _content;//文件内容

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Content {
            get { return _content; }
            set { _content = value; }
        }
    }

    class FileOperate
    {
        //这里调用读取分类的方法将打开的文件中的分类值读出来，没有就返回0--默认分类
        public static void OpenFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        //将文件类f保存
        public static void SaveFile(MyFile f)
        {
            FileStream fs = new FileStream(f.Name, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(f.Content);
            sw.Flush();
            sw.Close(); fs.Close();
        }

        //修改文件分类
        public static void UpdateFileCategory(MyFile f, string newpath)
        {
            File.Move(f.Name, newpath);
        }
    }
}
