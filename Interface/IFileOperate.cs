using Model;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> 79a961b16b97b3a97aaceabfaf4f5ddc10b55aae

namespace Interface
{
   public  interface IFileOperate
    {
<<<<<<< HEAD
        //打开文件接口,供控制台使用
        void OpenFile(string path);

        //打开文件接口,供窗体应用使用
        string OpenFileToString(string path);

=======
        //打开文件接口,供控制台使用,实验三以后弃用
        void OpenFile(string path);

        //根据路径打开文件接口,供窗体应用使用
        string OpenFileToString(string path);

        //通过指定的根目录返回文件列表
        List<MyFile> GetFilesByPath(string path);

>>>>>>> 79a961b16b97b3a97aaceabfaf4f5ddc10b55aae
        //保存文件接口
        void SaveFile(MyFile f);

        //修改文件分类
        void UpdateFileCategory(MyFile f, string newpath);
<<<<<<< HEAD
=======

        //文件类型互转
        SFile MyFileToSFile(MyFile f);
>>>>>>> 79a961b16b97b3a97aaceabfaf4f5ddc10b55aae
    }
}
