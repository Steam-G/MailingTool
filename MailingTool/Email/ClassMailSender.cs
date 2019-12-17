using System;
using System.Net;
using System.Net.Mail;

namespace MailingTool
{
    public class ClassMailSender
    {
        /// <summary>
        /// Отправка письма на почтовый ящик C# mail send
        /// </summary>
        /// <param name="smtpServer">Имя SMTP-сервера</param>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="displayName">Отображаемое имя отправителя</param>
        /// <param name="password">пароль к почтовому ящику отправителя</param>
        /// <param name="mailto">Адрес получателя</param>
        /// <param name="caption">Тема письма</param>
        /// <param name="message">Сообщение</param>
        /// <param name="attachFile">Присоединенный файл</param>
        public static void SendMail(string smtpServer, string from, string displayName, string password,
        string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();

                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        public static void SendHtmlMail(string smtpServer, string from, string displayName, string password,
        string mailto, string caption, string htmlBody, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.IsBodyHtml = true;
                mail.Body = htmlBody;
                if (!string.IsNullOrEmpty(attachFile))
                {
                    mail.Attachments.Add(new Attachment(attachFile));
                    //mail.Attachments[0].IsInline = true;
                    mail.Attachments[0].ContentId = "attachimg";
                }
                SmtpClient client = new SmtpClient();

                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }

        static string smtpServer;
        public string SMTPServer
        {
            get { return smtpServer; }
            set { if (smtpServer != value) smtpServer = value; }
        }

        static string from;
        public string From
        {
            get { return from; }
            set { if (from != value) from = value; }
        }

        static string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { if (displayName != value) displayName = value; }
        }

        static string password;
        public string Password
        {
            get { return password; }
            set { if (password != value) password = value; }
        }

        /// <summary>
        /// Параметры отправителя
        /// </summary>
        /// <param name="smtpServer">Имя SMTP-сервера</param>
        /// <param name="from">Адрес отправителя</param>
        /// <param name="displayName">Отображаемое имя отправителя</param>
        /// <param name="password">пароль к почтовому ящику отправителя</param>
        public void SenderConfig(string smtpServer, string from, string displayName, string password)
        {
            SMTPServer = smtpServer;
            From = from;
            DisplayName = displayName;
            Password = password;
        }

        /// <summary>
        /// Отправка письма, указать адрес, тему, сообщение и путь к файлу, если надо.
        /// </summary>
        /// <param name="mailto">Адрес получателя</param>
        /// <param name="caption">Тема письма</param>
        /// <param name="message">Сообщение</param>
        /// <param name="attachFile">Присоединенный файл</param>
        public void SendMail(string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();

                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
        }
    }
}
