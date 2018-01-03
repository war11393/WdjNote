namespace Model
{
    public class SFile
    {
        int _fno;
        string _fname;
        string _fcontent;
        int _fcno;
        int _funo;

        public SFile(int fno, string fname, string fcontent, int fcno, int funo)
        {
            _fno = fno;
            _fname = fname;
            _fcontent = fcontent;
            _fcno = fcno;
            _funo = funo;
        }

        public int Fno
        {
            get { return _fno; }
            set
            {
                _fno = value;
            }
        }
        public string Fname
        {
            get { return _fname; }
            set
            {
                _fname = value;
            }
        }
        public string Fcontent
        {
            get { return _fcontent; }
            set
            {
                _fcontent = value;
            }
        }
        public int Fcno
        {
            get
            {
                return _fcno;
            }

            set
            {
                _fcno = value;
            }
        }
        public int Funo
        {
            get
            {
                return _funo;
            }

            set
            {
                _funo = value;
            }
        }
    }
}
