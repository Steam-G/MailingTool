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
    public partial class EditPersonRecipientForm : Form
    {
        PersonRecipient personRecipient;

        public EditPersonRecipientForm(PersonRecipient personRecipient)
        {
            InitializeComponent();

            this.personRecipient = personRecipient;
            organizationTextBox.Text = personRecipient.Organization;
            recipientNameTextBox.Text = personRecipient.RecipientName;
            eMailTextBox.Text = personRecipient.EMail;
            noteTextBox.Text = personRecipient.Note;
        }

        public PersonRecipient EditedPerson
        {
            get { return personRecipient; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            personRecipient.Organization = organizationTextBox.Text;
            personRecipient.RecipientName = recipientNameTextBox.Text;
            personRecipient.EMail = eMailTextBox.Text;
            personRecipient.Note = noteTextBox.Text;
        }
    }
}
