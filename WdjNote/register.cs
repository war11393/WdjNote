using Interface;
using Model;
using SQLDAL;
using System;
using System.Windows.Forms;

namespace WdjNote
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btn_regist_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.ToString();
            string password = tb_password.Text.ToString();
            string repassword = tb_repassword.Text.ToString();
            string nick = tb_nick.Text.ToString();
            if (username == "" || password == "" || repassword == "" || nick == "")
            {
                MessageBox.Show("请输入完整信息");
            }
            else
            {
                if (password != repassword)
                {
                    MessageBox.Show("两次密码不一致!");
                }
                else
                {
                    IUserOperate userOperate = new UserOperateImpl();
                    User u = userOperate.Regist(username, password, nick);
                    if (u != null)
                    {
                        DialogResult dr = MessageBox.Show("注册成功！", "注册成功", MessageBoxButtons.OK);
                        if (dr == DialogResult.OK)
                        {
                            Program.lo.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名已存在！");
                        tb_nick.Text = "";
                        tb_password.Text = "";
                        tb_repassword.Text = "";
                        tb_username.Text = "";
                    }
                }
            }
        }

        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.lo.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Program.lo.Show();
            Close();
        }
    }
}
