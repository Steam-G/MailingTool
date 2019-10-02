﻿using System;
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


        //-------------------------------------------------------------------------

        List<PersonRecipient> persons = new List<PersonRecipient>();

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonRecipient person = new PersonRecipient("", "","", "");
            EditPersonRecipientForm editForm = new EditPersonRecipientForm(person);
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

            PersonRecipient person = persons[personsListView.SelectedIndices[0]];

            EditPersonRecipientForm editForm = new EditPersonRecipientForm(person);
            if (editForm.ShowDialog() == DialogResult.OK)
                personsListView.Invalidate();
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < persons.Count)
            {
                e.Item = new ListViewItem(persons[e.ItemIndex].Organization);
                e.Item.SubItems.Add(persons[e.ItemIndex].RecipientName);
                e.Item.SubItems.Add(persons[e.ItemIndex].EMail);
                e.Item.SubItems.Add(persons[e.ItemIndex].Note);
            }
        }

        private void personsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
