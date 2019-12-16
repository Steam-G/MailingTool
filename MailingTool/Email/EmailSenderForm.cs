﻿using System;
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

            //ClassMailSender.SendMail(
            //    "smtp.yandex.ru", 
            //    "prg.mail@yandex.ru", 
            //    "EmailSender(test)",
            //    "!!mailbox@@", 
            //    "l.andrey@npfgorizont.ru", 
            //    "Проверка отправки письма", 
            //    "Проверка написания сообщения в теле письма и попробую прикрепить pdf книгу",
            //    "C:\\Work\\Книги\\Программируемые контроллеры.Стандартные языки и приемы прикладного проектирования.pdf"
            //    );

            string testHtmlMail =
                "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\"><html xmlns=\"http://www.w3.org/1999/xhtml\"><head style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><meta name=\"viewport\" content=\"width=device-width\" style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"></head><body style=\"-webkit-font-smoothing:antialiased;-webkit-text-size-adjust:none;background:#efefef;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;height:100%;line-height:1.65;margin:0;padding:0;width:100%!important\"><style type=\"text/css\" style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"></style><table class=\"body-wrap\" style=\"-webkit-font-smoothing:antialiased;-webkit-text-size-adjust:none;background:#efefef;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;height:100%;line-height:1.65;margin:0;padding:0;width:100%!important\"><tbody><tr style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><td class=\"container\" style=\"clear:both!important;display:block!important;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0 auto!important;max-width:580px!important;padding:0\"><table style=\"border-collapse:collapse;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0;width:100%!important\"><tbody><tr style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><td class=\"masthead\" style=\"background:#71bc37;color:#fff;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:80px 0\" align=\"center\"><h1 style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:32px;line-height:1.25;margin:0 auto!important;margin-bottom:20px;max-width:90%;padding:0;text-transform:uppercase\">Something Big...</h1></td></tr><tr style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><td class=\"content\" style=\"background:#fff;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:30px 35px\"><h2 style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:28px;line-height:1.25;margin:0;margin-bottom:20px;padding:0\">Hi Stranger,</h2><p style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1.65;margin:0;margin-bottom:20px;padding:0\">Kielbasa venison ball tip shankle. Boudin prosciutto landjaeger, pancetta jowl turkey tri-tip porchetta beef pork loin drumstick. Frankfurter short ribs kevin pig ribeye drumstick bacon kielbasa. Pork loin brisket biltong, pork belly filet mignon ribeye pig ground round porchetta turducken turkey. Pork belly beef ribs sausage ham hock, ham doner frankfurter pork chop tail meatball beef pig meatloaf short ribs shoulder. Filet mignon ham hock kielbasa beef ribs shank. Venison swine beef ribs sausage pastrami shoulder.</p><table style=\"border-collapse:collapse;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0;width:100%!important\"><tbody><tr style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><td style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\" align=\"center\"><p style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1.65;margin:0;margin-bottom:20px;padding:0\"><a href=\"#\" class=\"button\" style=\"background:#71bc37;border:solid #71bc37;border-radius:4px;border-width:10px 20px 8px;color:#fff;display:inline-block;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;font-weight:700;line-height:1.65;margin:0;padding:0;text-decoration:none\">Share the Awesomeness</a></p></td></tr></tbody></table><p style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1.65;margin:0;margin-bottom:20px;padding:0\">By the way, if you're wondering where you can find more of this fine meaty filler, visit <a href=\"http://baconipsum.com\" style=\"color:#71bc37;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0;text-decoration:none\">Bacon Ipsum</a>.</p><p style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:16px;font-weight:400;line-height:1.65;margin:0;margin-bottom:20px;padding:0\"><em style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\">– Mr. Pen</em></p></td></tr></tbody></table></td></tr><tr style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><td class=\"container\" style=\"clear:both!important;display:block!important;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0 auto!important;max-width:580px!important;padding:0\"><table style=\"border-collapse:collapse;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0;width:100%!important\"><tbody><tr style=\"font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:0\"><td class=\"content footer\" style=\"background:0 0;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;line-height:1.65;margin:0;padding:30px 35px\" align=\"center\"><p style=\"color:#888;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:14px;font-weight:400;line-height:1.65;margin:0;margin-bottom:0;padding:0;text-align:center\">Sent by <a href=\"#\" style=\"color:#888;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;font-weight:700;line-height:1.65;margin:0;padding:0;text-decoration:none\">Company Name</a>, 1234 Yellow Brick Road, OZ, 99999</p><p style=\"color:#888;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:14px;font-weight:400;line-height:1.65;margin:0;margin-bottom:0;padding:0;text-align:center\"><a href=\"mailto:\" style=\"color:#888;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;font-weight:700;line-height:1.65;margin:0;padding:0;text-decoration:none\">hello@company.com</a> | <a href=\"#\" style=\"color:#888;font-family:'Avenir Next','Helvetica Neue',Helvetica,Helvetica,Arial,sans-serif;font-size:100%;font-weight:700;line-height:1.65;margin:0;padding:0;text-decoration:none\">Unsubscribe</a></p></td></tr></tbody></table></td></tr></tbody></table></body></html>";

            ClassMailSender.SendHtmlMail(
                "smtp.yandex.ru",
                "prg.mail@yandex.ru",
                "EmailSender(test)",
                "!!mailbox@@",
                "l.andrey@npfgorizont.ru",
                "Проверка отправки HTML письма",
                testHtmlMail
                //"C:\\Work\\Книги\\Программируемые контроллеры.Стандартные языки и приемы прикладного проектирования.pdf"
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
