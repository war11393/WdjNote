using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdjNote_01
{
    class File
    {
        int _cid;//分类id
        string _name;//路径+文件名
        string _content;//文件内容

        public int Cid {
            get { return _cid; }
            set { _cid = value; }
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Content {
            get { return _content; }
            set { _content = value; }
        }

        //这里调用读取分类的方法将打开的文件中的分类值读出来，没有就返回0--默认分类
        public void OpenFile(string path)
        {

        }

        //将文件类f保存
        public void SaveFile(File f)
        {
            
        }

        //修改文件分类
        public void UpdateFileCategory(File f, int cid)
        {

        }

        //读取文件类别
        public int ReadCategory(string content)
        {
            return 0;
        }
    }
}
