using Model;

namespace Interface
{
   public  interface IFileOperate
    {
        //打开文件接口,供控制台使用
        void OpenFile(string path);

        //打开文件接口,供窗体应用使用
        string OpenFileToString(string path);

        //保存文件接口
        void SaveFile(MyFile f);

        //修改文件分类
        void UpdateFileCategory(MyFile f, string newpath);
    }
}
