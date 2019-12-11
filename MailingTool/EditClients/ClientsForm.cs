﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingTool.EditClients
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            personRecipientTable1.SelectedIndexChanged += new EventHandler(UserControl_SelectedIndexChanged);
            eventRecipientVal1.btnApply_Click += new EventHandler(eventRecipientVal1_btnApply_Click);
        }

        // На форме два компонента: таблица и блок событий

        // При нажатии строки в таблице будет передан объект (пользователь) в блок событий, где отобразятся выбранные подписки (если ранее уже сохранялись)
        protected void UserControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventRecipientVal1.GetPersonRecipient = personRecipientTable1.GetRecipient(); // из компонента таблицы выбранный объект попадает в доп настройки
        }

        // При нажатии кнопки "Подписаться" в блоке событий будет выполнена функция сохранения из тыблицы в файл
        protected void eventRecipientVal1_btnApply_Click(object sender, EventArgs e)
        {
            personRecipientTable1.SaveToFile();
        }
    }
}
