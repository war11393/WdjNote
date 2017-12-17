using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WdjNote_01;

namespace WdjNote.expriment02
{
    class Category02 : Category
    {
        //添加新的分类
        public  void AddCategory(string name)
        {
            notelist.Add(name);
        }

        //删除已有分类
        public void DeleteCategory(string name)
        {
            notelist.Remove(name);
        }
    }
}
