using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using Model;

namespace WdjNote
{
    public partial class Form1 : Form
    {
        public delegate void SaveFile(MyFile f);//委托--保存文件
        public event SaveFile sf;
        public delegate string OpenFile(string s);//委托--打开文件
        public event OpenFile of;

        Category02 category = new Category02();
        public Form1()
        {
            InitializeComponent();
            tssWdj2.Text = System.DateTime.Now.ToString();
            foreach(string s in category.notelist){
                comboWdj.Items.Add(s);
            }
            comboWdj.Items.Add("新建分类");
            comboWdj.SelectedIndex = 0;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdWdj.FileName = "";
           ofdWdj.Filter = ("文本文件（*.txt)|*.txt|*.cs|*.cs");
          // ofdWdj.ShowDialog();

           
           string path = "D:\\" + category.notelist[comboWdj.SelectedIndex] + "\\";
           if (!Directory.Exists(path))
               Directory.CreateDirectory(path);
           ofdWdj.InitialDirectory = "D:\\" + category.notelist[comboWdj.SelectedIndex] + "\\";
          
           if (ofdWdj.ShowDialog() == DialogResult.OK)
           {
               try
               {
                   rtbWdj.Text = of(ofdWdj.FileName);
               }
               catch
               {
                   MessageBox.Show("文件打开失败", "提示", MessageBoxButtons.OK);
               }
           }
        }

        private void 保存文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             sfdWdj.Filter = ("文本文件（*.txt)|*.txt|所有文件(*.*)|*.*）");
             string path = "D:\\" + category.notelist[comboWdj.SelectedIndex] + "\\";
             if (!Directory.Exists(path))
                 Directory.CreateDirectory(path);
             sfdWdj.InitialDirectory = "D:\\" + category.notelist[comboWdj.SelectedIndex] + "\\";
            if ( sfdWdj.ShowDialog() == DialogResult.OK)
            {
                string myfilename =  sfdWdj.FileName;
                MyFile f = new MyFile();
                f.Path = path;
                myfilename = myfilename.Substring(myfilename.LastIndexOf("\\"));
                f.Name = myfilename;
                f.Content = rtbWdj.Text;
                sf(f);//调用保存文件事件
            }
        }

        private void 修改格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fontName;
            float fontSize;
            DialogResult fontdialogresult;
            FontStyle myfontstyle;
            fontdialogresult =  fdWdj.ShowDialog();
            if (fontdialogresult == DialogResult.OK)
            {
                fontName =  fdWdj.Font.Name;
                fontSize =  fdWdj.Font.Size;
                myfontstyle =  fdWdj.Font.Style;
                rtbWdj.SelectionFont = new Font(fontName, fontSize, myfontstyle);
            }
        }

        private void rtbWdj_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboWdj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboWdj.SelectedIndex==category.notelist.Count)
            {
                string str = Interaction.InputBox("提示信息", "标题", "文本内容", -1, -1);
               if(str!=null)
               {
                   comboWdj.Items.Remove("新建分类");
                   comboWdj.Items.Add(str);
                   comboWdj.Items.Add("新建分类");
                   category.AddCategory(str);
               }
            }
        }

        private void tWdj_Tick(object sender, EventArgs e)
        {
            tssWdj2.Text=System.DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
