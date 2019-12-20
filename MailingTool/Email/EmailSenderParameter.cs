using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MailingTool.Email
{
    public partial class EmailSenderParameter : UserControl
    {
        ClassMailSender mailSender = new ClassMailSender();
        ClassMailSender mailSenderBuffer;

        public EmailSenderParameter()
        {
            InitializeComponent();
            LoadParameters();

            txtServer.TextChanged += new System.EventHandler(this.parameterChanged);
            txtPort.TextChanged += new System.EventHandler(this.parameterChanged);
            checkSSL.CheckedChanged += new System.EventHandler(this.parameterChanged);
            txtLogin.TextChanged += new System.EventHandler(this.parameterChanged);
            txtPass.TextChanged += new System.EventHandler(this.parameterChanged);
            txtDisplayName.TextChanged += new System.EventHandler(this.parameterChanged);
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

            //Заполняем поля компонента
            if (mailSender != null)
            {
                txtServer.Text = mailSender.SMTPServer;
                txtPort.Text = mailSender.Port.ToString();
                checkSSL.Checked = mailSender.SSLstate;
                txtLogin.Text = mailSender.From;
                txtPass.Text = mailSender.Password;
                txtDisplayName.Text = mailSender.DisplayName;
            }
            else
            {
                mailSender = new ClassMailSender
                {
                    SMTPServer = "smtp.yandex.ru",
                    Port = 587,
                    SSLstate = true,
                    From = "",
                    Password = "",
                    DisplayName = ""
                };

                txtServer.Text = mailSender.SMTPServer;
                txtPort.Text = mailSender.Port.ToString();
                checkSSL.Checked = mailSender.SSLstate;
                txtLogin.Text = mailSender.From;
                txtPass.Text = mailSender.Password;
                txtDisplayName.Text = mailSender.DisplayName;
            }
        }

        public void SaveToFile()
        {
            if (mailSender != null && mailSenderBuffer != null) //проверка пустых объектов
            {
                if (!mailSender.Equals(mailSenderBuffer)) // проверка наличия различий, если нет различий то и сохранять не надо
                {
                    DialogResult dialogResult = MessageBox.Show("Сохранить?", "Настройки изменились", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.WriteAllText("SenderConfig.json", JsonConvert.SerializeObject(mailSenderBuffer, Formatting.Indented));
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }

        private void SaveDefaultParameter()
        {
            mailSenderBuffer = new ClassMailSender
            {
                SMTPServer = "smtp.yandex.ru",
                Port = 587,
                SSLstate = true,
                From = "",
                Password = "",
                DisplayName = ""
            };
            File.WriteAllText("SenderConfig.json", JsonConvert.SerializeObject(mailSenderBuffer, Formatting.Indented));
        }

        private void parameterChanged(object sender, EventArgs e)
        {
            mailSenderBuffer = new ClassMailSender
            {
                SMTPServer = txtServer.Text,
                Port = Convert.ToInt16(txtPort.Text),
                SSLstate = checkSSL.Checked,
                From = txtLogin.Text,
                Password = txtPass.Text,
                DisplayName = txtDisplayName.Text
            };
        }
    }
}
