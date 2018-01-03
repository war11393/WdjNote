using System.Collections.Generic;

namespace Interface
{
    public interface ICategoryOperate
    {
        //添加分类,在数据库添加分类后调用
        void AddCategory(string name);
        //删除分类，在数据库删除分类后调用
        void DeleteCategory(string name);
        //通过默认的根目录(D:\\WdjNote\\用户名)返回分类列表，返回失败就通过弹窗让用户指定路径
        List<string> GetCategory();
        //通过用户指定的根目录返回分类列表，暂时不实现
        List<string> GetCategory(string path);
    }
}
