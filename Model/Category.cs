using System.Collections.Generic;

namespace Model
{
    public class Category
    {
        int _cno;
        int _cuno;
        string _cname;
        List<SFile> _fileList;

        public Category(int cuno, string cname)
        {
            _cuno = cuno;
            _cname = cname;
        }

        public Category(int cno, int cuno, string cname)
        {
            _cno = cno;
            _cuno = cuno;
            _cname = cname;
        }

        public int Cno
        {
            get
            {
                return _cno;
            }

            set
            {
                _cno = value;
            }
        }
        public int Cuno
        {
            get
            {
                return _cuno;
            }

            set
            {
                _cuno = value;
            }
        }
        public string Cname
        {
            get
            {
                return _cname;
            }

            set
            {
                _cname = value;
            }
        }
        public List<SFile> FileList
        {
            get
            {
                return _fileList;
            }

            set
            {
                _fileList = value;
            }
        }
    }
}
