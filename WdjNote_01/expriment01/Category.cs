using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdjNote_01
{
    class Category
    {
        string[] _name;
        int[] _id;

        public string[] Name {
            get { return _name; }
            set { _name = value; }
        }
        public int[] Id {
            get { return _id; }
            set { _id = value; }
        }

        //添加新的分类
        public static void AddCategory(string name)
        {

        }

        //删除已有分类
        public static void DeleteCategory(int id)
        {

        }

        //显示现有分类
        public static void ShowCategory()
        {

        }
    }
}
