using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MailingTool
{
    public partial class EmailSenderForm : Form
    {
        public EmailSenderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassMailSender.SendMail(
                "smtp.yandex.ru", 
                "prg.mail@yandex.ru", 
                "EmailSender(test)",
                "!!mailbox@@", 
                "l.andrey@npfgorizont.ru", 
                "Проверка отправки письма", 
                "Проверка написания сообщения в теле письма и попробую прикрепить pdf книгу",
                "C:\\Work\\Книги\\Программируемые контроллеры.Стандартные языки и приемы прикладного проектирования.pdf"
                );
        }

        private void btnTestSend_Click(object sender, EventArgs e)
        {
            bool allok = true;

            //т.к. внутри контейнера у меня расположены еще контейнеры, то сперва проходим по ним
            foreach (Control x in panel1.Controls)
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
