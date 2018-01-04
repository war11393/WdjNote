using Model;
using System;
using System.Windows.Forms;

namespace Utils
{
    public class UIUpdate
    {
        public void AddCategory(TreeView tv, ComboBox cb, Category c)
        {
            TreeNode cnode = new TreeNode("新建分类");
            cnode.Tag = "-1";
            TreeNode fnode = new TreeNode("新建笔记");
            fnode.Tag = "-1";

            tv.Nodes.Remove(cnode);

            TreeNode newnode = new TreeNode(c.Cname);
            newnode.Tag = c.Cno;
            newnode.Nodes.Add(fnode);

            tv.Nodes.Add(newnode);
            tv.Nodes.Add(cnode);

            //更新下拉条儿
            cb.Items.Remove("新建分类");
            cb.Items.Add(c.Cname);
            cb.Items.Add("新建分类");
        }
    }
}
