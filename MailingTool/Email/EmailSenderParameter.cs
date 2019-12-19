using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingTool.Email
{
    public partial class EmailSenderParameter : UserControl
    {
        public EmailSenderParameter()
        {
            InitializeComponent();
        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            bool allok = true;

            //т.к. внутри контейнера у меня расположены еще контейнеры, то сперва проходим по ним
            foreach (Control x in Controls)
            {
                // теперь во вложенных контейнерах будем искать текстовые поля
                foreach (Control x2 in x.Controls)
                {
                    //проверка является ли элемент текстовым полем
                    if (x2 is TextBox)
                    {
                        if (((TextBox)x2).Text == "")
                        {
                            MessageBox.Show(
                             "Одно из полей не заполнено!",
                             "Ошибка",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);

                            allok = false;
                            break;
                        }
                    }
                }
            }

            if (allok)
            {
                string server = txtServer.Text;
                int port = Convert.ToInt16(txtPort.Text);
                bool sslstate = checkSSL.Checked;
                string login = txtLogin.Text;
                string pass = txtPass.Text;
                string displayname = txtDisplayName.Text;
                string emailtestsend = txtTestAdr.Text;
                string caption = "Проверка работы почтовой службы";
                string message = "Сообщение успешно доставлено, настройки верны.";

                ClassMailSender.SendMail(server, login, displayname, pass, emailtestsend, caption, message, null);
            }
        }
    }
}
