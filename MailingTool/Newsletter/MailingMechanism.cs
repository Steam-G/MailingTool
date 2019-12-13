using MailingTool.EditClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MailingTool.Newsletter
{
    public class MailingMechanism
    {
        static PersonListObj personList = new PersonListObj();
        static ClassMailSender MailSender = new ClassMailSender();
        private static System.Timers.Timer aTimer;

        private static List<PersonRecipient> recipients;

        private static void Send(string mailto, string caption, string message, string pathFile=null)
        {
            MailSender.SenderConfig(
                "smtp.yandex.ru",
                "prg.mail@yandex.ru",
                "EmailSender(test)",
                "!!mailbox@@");

            MailSender.SendMail(mailto, caption, message, pathFile);
        }


        /// <summary>
        /// Таймер, раз в секунду запускает событие
        /// </summary>
        /// <param name="elapsedEventHandler"></param>
        private static void SetTimer(ElapsedEventHandler elapsedEventHandler, bool start)
        {
            // Таймер
            // Создаем таймер с интервалом в 1 секунду.
            aTimer = new System.Timers.Timer(1000);
            // Подключаем событие Elapsed к таймеру. 
            aTimer.Elapsed += elapsedEventHandler;
            aTimer.AutoReset = true;
            aTimer.Enabled = start;
        }

        public void Start()
        {
            SetTimer(OnTimedEvent, true);
        }

        public void Stop()
        {
            SetTimer(OnTimedEvent, false);
        }

        /// <summary>
        /// Функция активации события по времени из объекта List<Zadacha>
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime tt = DateTime.Now;
            personList.ReloadPersonList();
            recipients = personList.PersonList;

            for (int i = 0; i < recipients.Count; i++)
            {
                foreach (string s in recipients[i].ListEventType)
                {
                    switch (s)
                    {
                        // Тип запуска: однократно в определенное время
                        case "Прогноз":
                            //if ()
                            //{
                                try
                                {
                                    //_ListZadach[i].Status = true;
                                    //foreach (Action a in _Actions)
                                    //    if (a.Method.Name == _ListZadach[i].TaskName) a();
                                }
                                catch
                                {
                                    //_ListZadach[i].Status = false;
                                }
                            //}
                            break;

                        // Тип запуска: каждый день в указанное время
                        case "Техническое состояние":
                            if (
                            tt.TimeOfDay.Hours == 16 &&
                            tt.TimeOfDay.Minutes == 0 &&
                            tt.TimeOfDay.Seconds == 0
                                )
                            {
                                try
                                {
                                    //_ListZadach[i].Status = true;
                                    //foreach (Action a in _Actions)
                                    //    if (a.Method.Name == _ListZadach[i].TaskName) a();
                                }
                                catch
                                {
                                    //_ListZadach[i].Status = false;
                                }
                            }
                            break;

                        // Тип запуска: по дням недели в указанное время
                        case "Отчет суточный":
                            if (
                            tt.TimeOfDay.Hours == 16 &&
                            tt.TimeOfDay.Minutes == 0 &&
                            tt.TimeOfDay.Seconds == 0
                                )
                            {
                                try
                                {
                                    Send(recipients[i].EMail, "Суточный отчет.", "Текстовое содержимое");
                                }
                                catch
                                {
                                    //_ListZadach[i].Status = false;
                                }
                            }
                            break;

                        // Тип запуска: каждый месяц в определенное число в указанное время
                        case "Отчет недельный":
                            if (
                            (int)tt.Date.DayOfWeek == (int)DayOfWeek.Friday &&
                            tt.TimeOfDay.Hours == 16 &&
                            tt.TimeOfDay.Minutes == 0 &&
                            tt.TimeOfDay.Seconds == 0
                                )
                            {
                                try
                                {
                                    Send(recipients[i].EMail, "Недельный отчет.", "Текстовое содержимое");
                                }
                                catch
                                {
                                    //_ListZadach[i].Status = false;
                                }
                            }
                            break;

                        case "Отчет месячный":
                            if (
                            tt.Date.Day == 13 &&
                            tt.TimeOfDay.Hours == 16 &&
                            tt.TimeOfDay.Minutes == 0 &&
                            tt.TimeOfDay.Seconds == 0
                                )
                            {
                                try
                                {
                                    Send(recipients[i].EMail, "Месячный отчет.", "Текстовое содержимое");
                                }
                                catch
                                {
                                    //_ListZadach[i].Status = false;
                                }
                            }
                            break;
                    }
                }
            }
        }
    }
}
