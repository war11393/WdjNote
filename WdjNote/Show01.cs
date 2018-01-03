using Model;
using System;

namespace WdjNote
{
    class Show01
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("欢迎使用豌豆荚笔记本！");
            Console.WriteLine("请选择相关操作：");
            Console.WriteLine("1.新建笔记");
            Console.WriteLine("2.打开笔记");
        }

        public static string OpenFileMenu()
        {
            Console.WriteLine("请输入文件路径与文件名：");
            string path = Console.ReadLine();
            return path;
        }

        public static MyFile CreateFileMenu()
        {
            MyFile file = new MyFile();

            Console.WriteLine("请输入笔记名：");
            string name = Console.ReadLine() + ".txt";

            //Console.WriteLine("请输入存储路径：(示例：C:\\Users\\11393\\Desktop\\C#)");
            //string path = Console.ReadLine() + "\\";

            Console.WriteLine("请输入文件分类：");
            Category category = new Category();
            string pa = category.ShowCategory("D:\\");

            Console.WriteLine("请输入笔记内容：(以#号键结束)");
            string content = "";
            string s = Console.ReadLine();
            
            while (!s.Equals("#"))
            {
                content += s;
                s = Console.ReadLine();
            }

            file.Path = pa;
            file.Name = name;
            file.Content = content;

            return file;
        }
    }
}
