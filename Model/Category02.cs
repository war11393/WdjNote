namespace Model
{
    public class Category02 : Category
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
