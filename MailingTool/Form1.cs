using MailingTool.EditClients;
using MailingTool.Newsletter;
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
    public partial class Form1 : Form
    {
        MailingMechanism mechanism = new MailingMechanism();

        public Form1()
        {
            InitializeComponent();
            mechanism.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TreeClientsForm treeClients = new TreeClientsForm();
            //treeClients.Show();
            ClientsForm clients = new ClientsForm();
            clients.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmailSenderForm emailSender = new EmailSenderForm();
            emailSender.Show();
        }
    }
}
