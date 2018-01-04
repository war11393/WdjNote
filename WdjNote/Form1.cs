using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using Model;
using Control;
using Interface;
using SQLDAL;
using System.Collections.Generic;

namespace WdjNote
{
    public partial class Form1 : Form
    {
        public delegate void SaveFile(MyFile f);//委托--保存文件
        public event SaveFile sf;
        public delegate string OpenFile(string s);//委托--打开文件
        public event OpenFile of;


        List<Category> clist = null;
        List<SFile> sflist = null;
        Dictionary<Category, List<SFile>> sFileMap = new Dictionary<Category, List<SFile>>();

        ISQLCategoryOperate co = new SQLCategoryOperateImpl();
        ISQLFileOperate fo = new SQLFileOperateImpl();

        private User user;

        private Category category;//当前分类
        private string currentPath;//当前本地路径
        private MyFile myFile = new MyFile();

        public Form1(User user)
        {
            InitializeComponent();
            this.user = user;
            tssWdj1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                login lo = new login();
                Hide();
                lo.Show();
            }
            else
            {
                lb_pre_username.Text = user.Unikename;
                tssWdj2.Text = System.DateTime.Now.ToString();
                LoadData();
            }
        }

        //装载分类与文件数据
        private void LoadData()
        {
            treeView1.Nodes.Clear();
            comboWdj.Items.Clear();
            clist = co.GetCategory(user.Uno);

            for (int j = 0; j < clist.Count; j++)
            {
                //下拉条儿初始化
                comboWdj.Items.Add(clist[j].Cname.Trim());

                sflist = fo.ReadFileByCno(clist[j].Cno, user.Uno);
                sFileMap.Add(clist[j], sflist);

                //树列表节点初始化
                //创建子节点
                TreeNode[] childNodes = new TreeNode[sflist.Count];
                for (int i = 0; i < sflist.Count; i++)
                {
                    childNodes[i] = new TreeNode(sflist[i].Fname.Trim());
                    childNodes[i].Tag = sflist[i].Fno;
                }
                //创建根节点
                TreeNode node = new TreeNode(clist[j].Cname.Trim(), childNodes);
                node.Tag = clist[j].Cno;
                treeView1.Nodes.Add(node);
                if (j == 0)
                    treeView1.SelectedNode = node;
            }

            //添加新建选项
            category = clist[0];
            comboWdj.Items.Add("新建分类");
            comboWdj.SelectedIndex = 0;

            TreeNode nnode = new TreeNode("新建分类");
            nnode.Tag = "-1";
            treeView1.Nodes.Add(nnode);
        }

        //树列表双击事件
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.Nodes.Count == 0 && node.Level == 1)//点击笔记
            {
                SFile sf = fo.OpenFile(Convert.ToInt32(node.Tag));
                rtbWdj.Text = sf.Fcontent.Trim();
                myFile.Path = currentPath;
                myFile.Name = sf.Fname.Trim() + ".txt";
                myFile.Content = sf.Fcontent.Trim();
                tssWdj1.Text = sf.Fname.Trim();
            }
            else//点击分类
            {
                if (node.Tag.ToString() == "-1")//新建分类
                {
                    AddCategory();
                }
                else
                {
                    for(int i = 0; i < clist.Count; i++)
                    {
                        if(Convert.ToInt32(node.Tag.ToString()) == clist[i].Cno)
                        {
                            comboWdj.SelectedIndex = i;
                        }
                    }
                }
            }
        }

        //打开本地文件
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdWdj.FileName = "";
            ofdWdj.Filter = ("文本文件（*.txt)|*.txt");

            if (!Directory.Exists(currentPath))
                Directory.CreateDirectory(currentPath);
            ofdWdj.InitialDirectory = currentPath;

            if (ofdWdj.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    myFile.Path = ofdWdj.FileName.Substring(0, ofdWdj.FileName.LastIndexOf("\\") + 1);
                    myFile.Name = ofdWdj.FileName.Substring(ofdWdj.FileName.LastIndexOf("\\") + 1);
                    myFile.Content = of(ofdWdj.FileName);
                    tssWdj1.Text = myFile.Name.Substring(0, myFile.Name.Length - 4);
                    rtbWdj.Text = myFile.Content;
                }
                catch
                {
                    MessageBox.Show("文件打开失败", "提示", MessageBoxButtons.OK);
                }
            }
        }

        //保存文件
        private void 保存文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanSave())
            {
                sfdWdj.Filter = ("文本文件（*.txt)|*.txt|所有文件(*.*)|*.*）");

                if (!Directory.Exists(currentPath))
                    Directory.CreateDirectory(currentPath);
                sfdWdj.InitialDirectory = currentPath;
                sfdWdj.FileName = tssWdj1.Text;

                if (sfdWdj.ShowDialog() == DialogResult.OK)
                {
                    myFile.Content = rtbWdj.Text;
                    sf(myFile);//调用保存文件事件
                }
            }
            else
            {
                MessageBox.Show("请先打开或新建一个笔记！");
            }
        }

        //保存到数据库
        private void 上传到云端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanSave())
            {
                SFile sf = new SFile(0, tssWdj1.Text, rtbWdj.Text, category.Cno, user.Uno);
                fo.SaveFile(sf);
                MessageBox.Show("上传成功！");
                LoadData();
            }
            else
                MessageBox.Show("请先打开或新建一个笔记！");
        }

        //下拉条选中状态改变
        private void comboWdj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboWdj.SelectedIndex == clist.Count)
            {
                AddCategory();
            }
            else if(comboWdj.SelectedIndex < clist.Count)
            {
                category = clist[comboWdj.SelectedIndex];
                currentPath = "D:\\WdjNote\\" + user.Unikename.Trim() + "\\" + clist[comboWdj.SelectedIndex].Cname.Trim() + "\\";
                myFile.Path = currentPath;
            }
        }

        //计时器
        private void tWdj_Tick(object sender, EventArgs e)
        {
            tssWdj2.Text=System.DateTime.Now.ToString();
        }

        //弹出添加分类框
        private void AddCategory()
        {
            string str = Interaction.InputBox("新建一个分类(长度最长为6，输入的分类名将会被截取前6个字)", "新建分类", "请输入新的分类名", -1, -1);
            if (str.Length > 6)
                str = str.Substring(0, 6);
            if (str != "新建分类")
            {
                co.AddCategory(user.Uno, str);
                LoadData();
            }
            else if(str == "新建分类")
            {
                MessageBox.Show("无效的分类名！");
            }
            else
            {
                MessageBox.Show("您输入的分类名过长！");
            }
        }

        //窗口关闭
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.lo.Close();
        }

        //修改文本框文本格式
        private void 修改格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fontName;
            float fontSize;
            DialogResult fontdialogresult;
            FontStyle myfontstyle;
            fontdialogresult = fdWdj.ShowDialog();
            if (fontdialogresult == DialogResult.OK)
            {
                fontName = fdWdj.Font.Name;
                fontSize = fdWdj.Font.Size;
                myfontstyle = fdWdj.Font.Style;
                rtbWdj.SelectionFont = new Font(fontName, fontSize, myfontstyle);
            }
        }

        //新建笔记
        private void 新建文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssWdj1.Text = Interaction.InputBox("新建一个笔记(笔记名最长为6，长出部分将会切除)", "新建笔记", "请输入笔记名", -1, -1);
            if(tssWdj1.Text.Length > 6)
                tssWdj1.Text = tssWdj1.Text.Substring(0, 6);
            rtbWdj.Text = "";
            myFile = new MyFile();
            myFile.Name = tssWdj1.Text + ".txt";
            myFile.Path = currentPath;
        }

        //判断是否可以保存
        private Boolean CanSave()
        {
            if (tssWdj1.Text == "")
                return false;
            else
                return true;
        }

        //删除选中的树列表节点
        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if(node.Text == "新建分类")
            {
                return;
            }
            if(node.Nodes.Count != 0)
            {
                DialogResult dr = MessageBox.Show("将要同时删除此分类下的笔记！", "警告", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (TreeNode n in node.Nodes)
                    {
                        fo.DeleteFile(Convert.ToInt32(n.Tag.ToString()));
                    }
                    co.DeleteCategory(Convert.ToInt32(node.Tag.ToString()));
                    LoadData();
                }
            }
            else if (node.Level == 0)
            {
                DialogResult dr = MessageBox.Show("确认删除此分类：" + node.Text, "提醒", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    co.DeleteCategory(Convert.ToInt32(node.Tag.ToString()));
                    LoadData();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("确认删除此笔记：" + node.Text, "提醒", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    fo.DeleteFile(Convert.ToInt32(node.Tag.ToString()));
                    LoadData();
                }
            }
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateMess update = new updateMess(user);
            update.Show();
        }
        //修改信息后更新本窗口信息
        public void UpdateName()
        {
            user = Program.user;
            lb_pre_username.Text = user.Unikename.Trim();
        }

        private void 团队介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("队伍名：豌豆荚（Wdj-王杜江）\n" +
                "团队成员：王伟、杜意权、江学才\n" +
                "更新日期：2018年1月4日", "团队介绍", MessageBoxButtons.OK);
        }

        private void 软件版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version:1.8.0", "版本信息", MessageBoxButtons.OK);
        }
    }
}
