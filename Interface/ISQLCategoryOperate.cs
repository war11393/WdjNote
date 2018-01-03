using Model;
using System.Collections.Generic;

namespace Interface
{
    public interface ISQLCategoryOperate
    {
        //添加分类,添加完成后需重新获取来更新项目数据
        void AddCategory(int uno, string name);
        //删除分类
        void DeleteCategory(int cno);
        //通过用户id返回分类列表
        List<Category> GetCategory(int uno);
    }
}
