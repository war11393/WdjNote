namespace Control
{
    public class CategoryOperate02 : CategoryOperate
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
