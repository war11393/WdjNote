using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;
using SQLDAL;
using Model;
namespace WdjNote
{
    public partial class updateMess : Form
    {
        public updateMess()
        {
            InitializeComponent();
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            //获取用户的唯一标识符
            int number = Program.user.Uno;
            //获取窗体中的信息
            string username = lb_username.Text.ToString();
            string password = tb_password.Text.ToString();
            string nick = tb_nickname.Text.ToString();
            //调用接口实现类
            IUserOperate userOperate = new UserOperateImpl();
            //封装对象
            User user = new User(number,username,nick);
            user.Upass = password;
            //修改信息，返回受影响的条数
           int m =  userOperate.UpdateInfo(user);
            if(m>0){//如果大于0表明修改成功否则失败
                MessageBox.Show("修改成功！");
            }else{
                MessageBox.Show("修改失败！");
            }
        }
    }
}
