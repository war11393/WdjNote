using System;
using WdjNote.expriment02;
using WdjNote_01.expriment1;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WdjNote.expriment03;
namespace WdjNote_01
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //string s = "!";
            //while(s.Equals("y") || s.Equals("Y"))
            //{
            //    ShowExperiment2();
            //    Console.WriteLine("是否继续？(y或Y继续，其他键退出)");
            //    s = Console.ReadLine();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            FileOprate02 fileOperate = new FileOprate02();
            f.of += fileOperate.OpenFileToString;
            f.sf += fileOperate.SaveFile;
            Application.Run(f);
        }

        //展示实验二菜单
        private static void ShowExperiment2()
        {
            Show02.ShowMainMenu();
            int i = int.Parse(System.Console.ReadLine());
            FileOperate fileOperate = new FileOperate();
            switch (i)
            {
                case 1:
                    MyFile f = Show02.CreateFileMenu();
                    fileOperate.SaveFile(f);
                    break;
                case 2:
                    string s = Show02.OpenFileMenu();
                    fileOperate.OpenFile(s);
                    break;
                case 3:
                    Console.WriteLine("请输入删除路径：");
                    string deletepath = Console.ReadLine();
                    FileOprate02.DeleteFile(deletepath);
                    break;
                case 4:
                    Show02.ShowCategoryMenu();
                    int j = int.Parse(System.Console.ReadLine());
                    Category02 category = new Category02();
                    if (j == 1)
                    {
                        Console.WriteLine("请输入新的分类名：");
                        string newcate = Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("请输入要删除的分类名：");
                        string deletecate = Console.ReadLine();
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("请输入正确指令！");
                    break;
            }
        }

        //展示实验一菜单
        private static void ShowExperiment1()
        {
            Show01.ShowMainMenu();
            int i = int.Parse(System.Console.ReadLine());
            FileOperate fileOperate = new FileOperate();
            switch (i)
            {
                case 1:
                    MyFile f = Show01.CreateFileMenu();
                    fileOperate.SaveFile(f);
                    break;
                case 2:
                    string s = Show01.OpenFileMenu();
                    fileOperate.OpenFile(s);
                    break;
                default:
                    Console.WriteLine("请输入正确指令！");
                    break;
            }
        }
    }
}
