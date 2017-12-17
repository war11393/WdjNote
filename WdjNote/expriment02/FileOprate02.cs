using System.IO;
using WdjNote_01;

namespace WdjNote.expriment02
{
    class FileOprate02 : FileOperate
    {
        public static void DeleteFile(string path)
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
