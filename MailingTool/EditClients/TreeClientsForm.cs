using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingTool
{
    public partial class TreeClientsForm : Form
    {
        public TreeClientsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("Корневой элемент");
            treeView1.Nodes.Add(newNode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Nodes.Add("Дочерний элемент");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Remove();
        }
    }
}
