using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailingTool.EditClients;
using Newtonsoft.Json;

namespace MailingTool
{
    public partial class TreeClientsForm : Form
    {
        PersonListObj personListObj = new PersonListObj();
        PersonListObj buferListObj = new PersonListObj();

        public TreeClientsForm()
        {
            InitializeComponent();

            personListObj.PersonList = new List<PersonRecipient> { };

            // Создаем объект с данными из файла .json, если файла нет то просто заводим новый пустой объект
            var PersonObj = File.Exists(path: "person.json") ? JsonConvert.DeserializeObject<PersonListObj>(File.ReadAllText("person.json")) : new PersonListObj();
            
            personListObj = PersonObj;
            buferListObj = personListObj;
            bool eq = personListObj.Equals(buferListObj);
            // Обновляем таблицу с данными
            personsListView.VirtualListSize = personListObj.PersonList.Count;
            personsListView.Invalidate();

            //this.FormClosing += new System.EventHandler(closeForm);
            //this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
        }


        // Кнопка добавления в список нового пользователя
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonRecipient person = new PersonRecipient("", "", "", "","",null);

            EditPersonRecipientForm editForm = new EditPersonRecipientForm(person);


            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            // Если списка еще нет, то заведем новый пустой
            if (personListObj.PersonList == null) personListObj.PersonList = new List<PersonRecipient> { };
            personListObj.PersonList.Add(person);

            // Просто пример того как сериализуются данные
            string json = JsonConvert.SerializeObject(personListObj.PersonList, Formatting.Indented);

            // Запись в файл сериализованных данных
            File.WriteAllText("person.json", JsonConvert.SerializeObject(personListObj, Formatting.Indented));

            // Обновляем таблицу с данными
            personsListView.VirtualListSize = personListObj.PersonList.Count;
            personsListView.Invalidate();
        }

        private void delPersonButton_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;
            // НЕ РАБОТАЕТ МАССОВОЕ УДАЛЕНИЕ ИЗ СПИСКА, ИСПОЛЬЗУЮТСЯ ИНДЕКСЫ
            for (int i= personsListView.SelectedIndices.Count-1; i>=0 ; i--)
            {
                int indeks = personsListView.SelectedIndices[i];
                personListObj.PersonList.RemoveAt(indeks);
            }
            try
            {
                if (personsListView.SelectedIndices.Count != 0) personsListView.SelectedIndices.Clear();
            }
            catch { }
            

            personsListView.VirtualListSize = personListObj.PersonList.Count;
            personsListView.Invalidate();
        }

        // Кнопка редактирования выбранного в списке пользователя
        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;

            PersonRecipient person = personListObj.PersonList[personsListView.SelectedIndices[0]];
            //PersonRecipient person = persons[personsListView.SelectedIndices[0]];

            EditPersonRecipientForm editForm = new EditPersonRecipientForm(person);
            if (editForm.ShowDialog() == DialogResult.OK)
                personsListView.Invalidate();
            else return;

            File.WriteAllText("person.json", JsonConvert.SerializeObject(personListObj, Formatting.Indented));
        }

        // Работа с виртуальными элементами (имеет смысл при работе с большими списками)
        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < personListObj.PersonList.Count)
            {
                e.Item = new ListViewItem(personListObj.PersonList[e.ItemIndex].Organization);
                e.Item.SubItems.Add(personListObj.PersonList[e.ItemIndex].RecipientName);
                e.Item.SubItems.Add(personListObj.PersonList[e.ItemIndex].EMail);
                e.Item.SubItems.Add(personListObj.PersonList[e.ItemIndex].Note);
            }
            //if (e.ItemIndex >= 0 && e.ItemIndex < persons.Count)
            //{
            //    e.Item = new ListViewItem(persons[e.ItemIndex].Organization);
            //    e.Item.SubItems.Add(persons[e.ItemIndex].RecipientName);
            //    e.Item.SubItems.Add(persons[e.ItemIndex].EMail);
            //    e.Item.SubItems.Add(persons[e.ItemIndex].Note);
            //}
        }

        private void personsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void TreeClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (buferListObj.Equals(personListObj))
                MessageBox.Show("Данные не менялись");
            else
                MessageBox.Show("Данные изменились");
        }
    }
}
