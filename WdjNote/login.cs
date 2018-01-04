using System;
using System.Windows.Forms;
using Interface;
using Model;
using SQLDAL;

namespace WdjNote
{
    public partial class login : Form
    {
        User user = null;

        public login()
        {
            InitializeComponent();
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            register re = new register();
            re.Show();
            Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();
            if(username == "" || password == "")
            {
                MessageBox.Show("请输入完整的信息");
            }
            else
            {
                IUserOperate userOperate = new UserOperateImpl();
                user = userOperate.Login(username, password);
                if(user != null)
                {
                    Program.user = user;
                    Program.StartMainForm();
                    Hide();
                }
                else
                {
                    MessageBox.Show("请输入正确的用户名和密码！");
                }
            }
        }
    }
}
