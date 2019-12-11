﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingTool.EditClients
{
    public partial class EventRecipientVal : UserControl
    {
        PersonRecipient _GetPersonRecipient = new PersonRecipient("", "", "", "", "", null);
        List<string> ObjectList = new List<string>{"Качалка 1", "Качалка 2", "Качалка 3", "Качалка 4", "Качалка 5", "Качалка 6"}; // Эти данные надо будет забирать программно
        List<string> EventList = new List<string> {"Прогноз","Техническое состояние","Отчет суточный","Отчет недельный","Отчет месячный" }; // Эти данные надо будет забирать программно

        List<string> _selectedEvents = new List<string>();

        public event EventHandler btnApply_Click;

        public EventRecipientVal()
        {
            InitializeComponent();
            Setup();
            
            //comboBoxObject.DataSource = ObjectList;
            //comboBoxObject.Text = "Выберите объект";

            //checkedListBoxEvent.Items.Clear();
            //for (int i = 0; i < EventList.Count; i++)
            //    checkedListBoxEvent.Items.Add(EventList[i], false);
        }

        public void Setup()
        {
            comboBoxObject.DataSource = ObjectList;
            comboBoxObject.Text = "Выберите объект";
            comboBoxObject.Invalidate();

            checkedListBoxEvent.Items.Clear();
            for (int i=0; i< EventList.Count;i++)
            checkedListBoxEvent.Items.Add(EventList[i],false);

        }

        public PersonRecipient GetPersonRecipient
        {
            get { return _GetPersonRecipient; }
            set { if (_GetPersonRecipient != value)
                    {
                        _GetPersonRecipient = value;

                        Setup(); // сброс списков к начальному виду

                        try
                        {
                            comboBoxObject.SelectedIndex = comboBoxObject.FindStringExact(value.ObjectName); // поиск по слову

                            foreach (string s in value.ListIdRecipient)
                            {
                                int valIndex = checkedListBoxEvent.FindStringExact(s); // это индекс объекта из списка.
                                checkedListBoxEvent.SetItemChecked(valIndex, true);
                            }
                        }
                        catch { }
                    }
                }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (this.btnApply_Click != null)
                this.btnApply_Click(this, e);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void comboBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetPersonRecipient.ObjectName = comboBoxObject.Text;
        }

        private void checkedListBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedEvents.Clear();
                for (int i = 0; i < checkedListBoxEvent.Items.Count; i++)
                {
                    if (checkedListBoxEvent.GetItemCheckState(i) == CheckState.Checked)
                        _selectedEvents.Add(checkedListBoxEvent.Items[i].ToString());
                }
                _GetPersonRecipient.ListIdRecipient = _selectedEvents;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Сперва стоит выбрать подписчика.");
                return;
            }
        }
    }

}
