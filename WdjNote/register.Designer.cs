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
            this.btn_regist = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.repassword = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_repassword = new System.Windows.Forms.TextBox();
            this.tb_nick = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(286, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 287);
            this.panel1.TabIndex = 0;
            // 
            // btn_regist
            // 
            this.btn_regist.Location = new System.Drawing.Point(45, 247);
            this.btn_regist.Name = "btn_regist";
            this.btn_regist.Size = new System.Drawing.Size(75, 23);
            this.btn_regist.TabIndex = 0;
            this.btn_regist.Text = "注册";
            this.btn_regist.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(165, 247);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(59, 53);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(41, 12);
            this.username.TabIndex = 2;
            this.username.Text = "用户名";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(59, 100);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(29, 12);
            this.password.TabIndex = 3;
            this.password.Text = "密码";
            // 
            // repassword
            // 
            this.repassword.AutoSize = true;
            this.repassword.Location = new System.Drawing.Point(59, 150);
            this.repassword.Name = "repassword";
            this.repassword.Size = new System.Drawing.Size(53, 12);
            this.repassword.TabIndex = 4;
            this.repassword.Text = "确认密码";
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(61, 194);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(29, 12);
            this.nick.TabIndex = 5;
            this.nick.Text = "昵称";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(140, 43);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 21);
            this.tb_username.TabIndex = 6;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(140, 90);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 21);
            this.tb_password.TabIndex = 7;
            // 
            // tb_repassword
            // 
            this.tb_repassword.Location = new System.Drawing.Point(140, 140);
            this.tb_repassword.Name = "tb_repassword";
            this.tb_repassword.Size = new System.Drawing.Size(100, 21);
            this.tb_repassword.TabIndex = 8;
            // 
            // tb_nick
            // 
            this.tb_nick.Location = new System.Drawing.Point(140, 194);
            this.tb_nick.Name = "tb_nick";
            this.tb_nick.Size = new System.Drawing.Size(100, 21);
            this.tb_nick.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WdjNote.Properties.Resources._86;
            this.pictureBox1.Location = new System.Drawing.Point(29, 38);
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
            this.ClientSize = new System.Drawing.Size(564, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "register";
            this.Text = "Wdj记事本";
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