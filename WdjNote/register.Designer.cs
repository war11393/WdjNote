namespace WdjNote
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_nick = new System.Windows.Forms.TextBox();
            this.tb_repassword = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.Label();
            this.repassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_regist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_nick);
            this.panel1.Controls.Add(this.tb_repassword);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.nick);
            this.panel1.Controls.Add(this.repassword);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_regist);
            this.panel1.Location = new System.Drawing.Point(267, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 274);
            this.panel1.TabIndex = 0;
            // 
            // tb_nick
            // 
            this.tb_nick.Location = new System.Drawing.Point(119, 171);
            this.tb_nick.Name = "tb_nick";
            this.tb_nick.Size = new System.Drawing.Size(100, 21);
            this.tb_nick.TabIndex = 9;
            // 
            // tb_repassword
            // 
            this.tb_repassword.Location = new System.Drawing.Point(121, 122);
            this.tb_repassword.Name = "tb_repassword";
            this.tb_repassword.PasswordChar = '*';
            this.tb_repassword.Size = new System.Drawing.Size(100, 21);
            this.tb_repassword.TabIndex = 8;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(121, 76);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 21);
            this.tb_password.TabIndex = 7;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(121, 24);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 21);
            this.tb_username.TabIndex = 6;
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(40, 174);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(29, 12);
            this.nick.TabIndex = 5;
            this.nick.Text = "昵称";
            // 
            // repassword
            // 
            this.repassword.AutoSize = true;
            this.repassword.Location = new System.Drawing.Point(40, 125);
            this.repassword.Name = "repassword";
            this.repassword.Size = new System.Drawing.Size(53, 12);
            this.repassword.TabIndex = 4;
            this.repassword.Text = "确认密码";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(40, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(29, 12);
            this.password.TabIndex = 3;
            this.password.Text = "密码";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(40, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(41, 12);
            this.username.TabIndex = 2;
            this.username.Text = "用户名";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(146, 222);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_regist
            // 
            this.btn_regist.Location = new System.Drawing.Point(26, 222);
            this.btn_regist.Name = "btn_regist";
            this.btn_regist.Size = new System.Drawing.Size(75, 23);
            this.btn_regist.TabIndex = 0;
            this.btn_regist.Text = "注册";
            this.btn_regist.UseVisualStyleBackColor = true;
            this.btn_regist.Click += new System.EventHandler(this.btn_regist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WdjNote.Properties.Resources._86;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.register_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_nick;
        private System.Windows.Forms.TextBox tb_repassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.Label repassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_regist;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}