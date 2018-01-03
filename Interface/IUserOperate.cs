using Model;

namespace Interface
{
    interface IUserOperate
    {
        User Login(string username, string password);
        void Regist(string username, string password, string nickname);
        void UpdateInfo(User u);
    }
}
