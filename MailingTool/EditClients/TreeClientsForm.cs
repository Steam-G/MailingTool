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


        List<Person> persons = new List<Person>();

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person("", "","");
            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            persons.Add(person);
            personsListView.VirtualListSize = persons.Count;
            personsListView.Invalidate();
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;

            Person person = persons[personsListView.SelectedIndices[0]];

            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() == DialogResult.OK)
                personsListView.Invalidate();
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < persons.Count)
            {
                e.Item = new ListViewItem(persons[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(persons[e.ItemIndex].LastName);
                e.Item.SubItems.Add(persons[e.ItemIndex].Age.ToString());
                e.Item.SubItems.Add(persons[e.ItemIndex].EMail);
            }
        }

        private void personsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
