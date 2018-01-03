namespace Model
{
    public class MyFile
    {
        string _path;//路径(包含分类名)
        string _name;//文件名
        string _content;//文件内容

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Content {
            get { return _content; }
            set { _content = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
    }
}
