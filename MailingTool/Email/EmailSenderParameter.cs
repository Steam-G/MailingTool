using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MailingTool.Email
{
    public partial class EmailSenderParameter : UserControl
    {
        ClassMailSender mailSender = new ClassMailSender();
        ClassMailSender mailSenderBuffer = new ClassMailSender();

        public EmailSenderParameter()
        {
            InitializeComponent();
            LoadParameters();
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

        public void LoadParameters()
        {
            // Создаем объект с данными из файла .json, если файла нет то просто заводим новый пустой объект
            var PersonObj = File.Exists(path: "SenderConfig.json") ? JsonConvert.DeserializeObject<ClassMailSender>(File.ReadAllText("SenderConfig.json")) : new ClassMailSender();
            mailSender = PersonObj;
            //mailSenderBuffer = mailSender;
        }

        public void SaveToFile()
        {
            if (!mailSender.Equals(mailSenderBuffer))
            {
                DialogResult dialogResult = MessageBox.Show("Настройки изменились", "Сохранить?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.WriteAllText("SenderConfig.json", JsonConvert.SerializeObject(mailSender, Formatting.Indented));
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            
        }

        private void parameterChanged(object sender, EventArgs e)
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

           //mailSenderBuffer.SenderConfig(server, port, sslstate, login, displayname, pass);

            mailSenderBuffer.SMTPServer = server;
            mailSenderBuffer.Port = port;
            mailSenderBuffer.SSLstate = sslstate;
            mailSenderBuffer.From = login;
            mailSenderBuffer.Password = pass;
            mailSenderBuffer.DisplayName = displayname;

        }
    }
}
