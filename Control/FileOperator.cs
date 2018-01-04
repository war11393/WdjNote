using Interface;
using Model;
using System;
using System.IO;
using System.Collections.Generic;
namespace Control
{
    public class FileOperate : IFileOperate
    {
        //这里调用读取分类的方法将打开的文件中的分类值读出来，没有就返回0--默认分类
        //供控制台使用
        public void OpenFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        //供窗体应用使用
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
        //通过指定的根目录返回文件列表
        public List<MyFile> GetFilesByPath(string path)
        {
            List<MyFile> myfile = new List<MyFile>();
            DirectoryInfo theFolder = new DirectoryInfo(path);
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                // this.listBox1.Items.Add(NextFolder.Name);
                FileInfo[] fileInfo = NextFolder.GetFiles();
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                {
                    MyFile fi = new MyFile();
                    fi.Name = NextFile.Name;
                    fi.Path = path + "\\" + NextFile.Name + ".txt";
                    fi.Content = "";
                    if (File.Exists(fi.Path))
                    {
                        List<string[]> list = new List<string[]>();
                        // 打开文件时 一定要注意编码 也许你的那个文件并不是GBK编码的
                        using (StreamReader sr = new StreamReader(fi.Path, System.Text.Encoding.GetEncoding("GBK")))
                        {
                            while (!sr.EndOfStream) //读到结尾退出
                            {
                                fi.Content =fi.Content+ sr.ReadLine();
                            }
                        }
                       
                    }
                    myfile.Add(fi);
                }
            }
            return myfile;
        }
        //保存文件
        public void SaveFile(MyFile f)
        {
            if (Directory.Exists(f.Path) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(f.Path);
            }
            FileStream fs = new FileStream(f.Path + f.Name, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(f.Content);
            sw.Flush();
            sw.Close(); fs.Close();
        }
        //修改文件分类
        public void UpdateFileCategory(MyFile f, string newpath)
        {
            File.Move(f.Name, newpath);
            File.Move(f.Path + "\\" + f.Name, newpath);
        } 

       // 文件类型互转
        public SFile MyFileToSFile(MyFile f)
        {
            throw new NotImplementedException();
        }

        //删除文件夹
        public void DeleteFile(string path)
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr == FileAttributes.Directory)
            {
                Directory.Delete(path, true);
            }
            else
            {
                File.Delete(path);
            }
        }
    }
}
