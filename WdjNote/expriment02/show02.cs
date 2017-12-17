using System;
using WdjNote_01.expriment1;

namespace WdjNote.expriment02
{
    class Show02 : Show01
    {
        public new static void ShowMainMenu()
        {
            Console.WriteLine(" ***************************************************************");
            Console.WriteLine(" *                        请选择相关操作                       *");
            Console.WriteLine(" *             1.新建笔记                2.打开笔记            *");
            Console.WriteLine(" *             3.删除笔记                4.管理分类            *");
            Console.WriteLine(" *             5.退出                                          *");
            Console.WriteLine(" ***************************************************************");
        }

        public static void ShowCategoryMenu()
        {
            Console.WriteLine(" ***************************************************************");
            Console.WriteLine(" *                        请选择相关操作                       *");
            Console.WriteLine(" *             1.添加分类                2.删除分类            *");
            Console.WriteLine(" ***************************************************************");
        }

        public static void DeleteFile(string path)
        {

        }
    }
}
