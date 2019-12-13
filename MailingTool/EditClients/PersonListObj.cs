using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingTool.EditClients
{
    public class PersonListObj //: IEnumerable, IEnumerator
    {
        public List<PersonRecipient> PersonList { get; set; }

        public void LoadPersonList()
        {
            // Создаем объект с данными из файла .json, если файла нет то просто заводим новый пустой объект
            var PersonObj = File.Exists(path: "person.json") ? JsonConvert.DeserializeObject<PersonListObj>(File.ReadAllText("person.json")) : new PersonListObj();
            PersonList = PersonObj.PersonList;
        }
        //protected int size;
        //protected int index;
        //private int pos = -1;

       public void ReloadPersonList()
        {
            if (PersonList != null)
            PersonList.Clear();
            // Создаем объект с данными из файла .json, если файла нет то просто заводим новый пустой объект
            var PersonObj = File.Exists(path: "person.json") ? JsonConvert.DeserializeObject<PersonListObj>(File.ReadAllText("person.json")) : new PersonListObj();
            PersonList = PersonObj.PersonList;
        }

        //public int Count
        //{
        //    get { return PersonList.Capacity; }
        //}

        //#region Члены IEnumerable

        //public IEnumerator GetEnumerator()
        //{
        //    return PersonList.GetEnumerator();
        //}
        //#endregion

        //#region Члены IEnumerator
        //public bool MoveNext()
        //{
        //    if (pos < PersonList.Capacity)
        //    {
        //        pos++;
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //public void Reset()
        //{
        //    pos = 0;
        //}

        //public object Current
        //{
        //    get { return PersonList[pos]; }
        //}

        //#endregion
    }
}
