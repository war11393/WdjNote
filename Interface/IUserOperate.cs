using Model;

namespace Interface
{
    public interface IUserOperate
    {
        User Login(string username, string password);
        User FindUserByUsername(string name);
        User Regist(string username, string password, string nickname);
        int UpdateInfo(User u);
    }
}
