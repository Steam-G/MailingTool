using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingTool.Newsletter
{
    class MailingMechanism
    {
        ClassMailSender MailSender = new ClassMailSender();
        
        private void Send(string mailto, string caption, string message, string pathFile=null)
        {
            MailSender.SenderConfig(
                "smtp.yandex.ru",
                "prg.mail@yandex.ru",
                "EmailSender(test)",
                "!!mailbox@@");

            MailSender.SendMail(mailto, caption, message, pathFile);
        }
    }
}
