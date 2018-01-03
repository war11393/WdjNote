namespace Model
{
    public class User
    {
        int _uno;
        string _uname;
        string _upass;
        string _unikename;

        public User(int uno, string uname, string unikename)
        {
            _uno = uno;
            _uname = uname;
            _unikename = unikename;
        }

        public int Uno
        {
            get
            {
                return _uno;
            }

            set
            {
                _uno = value;
            }
        }
        public string Uname
        {
            get
            {
                return _uname;
            }

            set
            {
                _uname = value;
            }
        }
        public string Upass
        {
            get
            {
                return _upass;
            }

            set
            {
                _upass = value;
            }
        }
        public string Unikename
        {
            get
            {
                return _unikename;
            }

            set
            {
                _unikename = value;
            }
        }
    }
}
