using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingTool.EditClients
{
    public class PersonListObj //: IEnumerable, IEnumerator
    {
        public List<PersonRecipient> PersonList { get; set; }

        //protected int size;
        //protected int index;
        //private int pos = -1;

       

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
