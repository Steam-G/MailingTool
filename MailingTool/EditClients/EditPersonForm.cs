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
    public partial class EditPersonForm : Form
    {
        Person person;

        public EditPersonForm(Person person)
        {
            InitializeComponent();

            this.person = person;
            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
            ageNumericUpDown.Value = person.Age;
            eMailTextBox.Text = person.EMail;
        }

        public Person EditedPerson
        {
            get { return person; }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
            person.Age = (int)ageNumericUpDown.Value;
            person.EMail = eMailTextBox.Text;
        }
    }
}
