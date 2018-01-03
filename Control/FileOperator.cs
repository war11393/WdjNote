using Interface;
using Model;
using System;
using System.IO;

namespace Control
{
    public class FileOperate : IFileOperate
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
        public void SaveFile(MyFile f)
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
        public void UpdateFileCategory(MyFile f, string newpath)
        {
<<<<<<< HEAD
            File.Move(f.Name, newpath);
=======
            File.Move(f.Path + "\\" + f.Name, newpath);
>>>>>>> 79a961b16b97b3a97aaceabfaf4f5ddc10b55aae
        }
    }
}
