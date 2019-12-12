using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingTool
{
    /// <summary>
    /// Класс описывающий получателя электронной рассылки.
    /// </summary>
    public class PersonRecipient //: IEnumerable
    {
        public delegate void NameChanged(Object sender, NameChangedEvent args);

        public event NameChanged OrganizationChanged;
        public event NameChanged RecipientNameChanged;
        public event NameChanged EMailChanged;
        public event NameChanged NoteChanged;
        public event NameChanged ObjectNameChanged;

        public PersonRecipient(string organization, string recipientName, string email, string note, string objectName, List<string> listEventType)
        {
            //...........
            Organization = organization;
            RecipientName = recipientName;
            EMail = email;
            Note = note;
            ObjectName = objectName;
            ListEventType = listEventType;
        }

        #region Свойства

        string organization;
        public string Organization
        {
            get { return organization; }
            set
            {
                if (OrganizationChanged != null)
                    OrganizationChanged(this,
                        new NameChangedEvent(value,
                            NameChangedEvent.NameChangingKind.FirstName)
                            );
                organization = value;
            }
        }

        string recipientName;
        public string RecipientName
        {
            get { return recipientName; }
            set
            {
                if (RecipientNameChanged != null)
                {
                    NameChangedEvent changeevent = new NameChangedEvent(value, NameChangedEvent.NameChangingKind.FirstName);
                    RecipientNameChanged(this, changeevent);
                    if (changeevent.Canceled)
                        return;
                }

                recipientName = value;
            }
        }

        string email;
        public string EMail
        {
            get { return email; }
            set
            {
                if (EMailChanged != null)
                {
                    NameChangedEvent changeevent = new NameChangedEvent(value, NameChangedEvent.NameChangingKind.FirstName);
                    EMailChanged(this, changeevent);
                    if (changeevent.Canceled)
                        return;
                }
                email = value;
            }
        }

        string note;
        public string Note
        {
            get { return note; }
            set
            {
                if (NoteChanged != null)
                {
                    NameChangedEvent changeevent = new NameChangedEvent(value, NameChangedEvent.NameChangingKind.FirstName);
                    NoteChanged(this, changeevent);
                    if (changeevent.Canceled)
                        return;
                }
                note = value;
            }
        }

        string objectName;
        public string ObjectName
        {
            get { return objectName; }
            set
            {
                if (ObjectNameChanged != null)
                {
                    NameChangedEvent changeevent = new NameChangedEvent(value, NameChangedEvent.NameChangingKind.FirstName);
                    ObjectNameChanged(this, changeevent);
                    if (changeevent.Canceled)
                        return;
                }
                objectName = value;
            }
        }

        List<string> listEventType;
        public List<string> ListEventType
        {
            get { return listEventType; }
            set
            {
                if (value != null)
                {
                    listEventType = value;
                }

            }
        }
        #endregion

        #region Унаследованные методы от Object

        // метод перевода объекта в строку
        public new string ToString()
        {
            return RecipientName + ", " + Organization + ", " + EMail;
        }

        // метод сравнения объектов
        public new bool Equals(Object obj)
        {
            PersonRecipient personRecipient = (PersonRecipient)obj;
            return (Organization == personRecipient.Organization) &&
                   (RecipientName == personRecipient.RecipientName);
        }

        public string ComparePersons(PersonRecipient personRecipient)
        {
            bool equalParams = Equals(personRecipient);
            bool fullEqual = base.Equals(personRecipient);

            if (fullEqual)
                return "Абсолютно одинаковые объекты";
            if (equalParams)
                return "Одинаковые свойства объектов";

            return "Объекты разные";
        }

        

        #endregion

        //#region Дети (осталось от копирования)

        //ArrayList Children = new ArrayList();

        //public void AddChild(string organization, string recipientName, string email, string note)
        //{
        //    Children.Add(new PersonRecipient(organization, recipientName, email, note));
        //}

        //public void DeleteChild(int index)
        //{
        //    Children.RemoveAt(index);
        //}

        //public PersonRecipient GetChild(int index)
        //{
        //    return (PersonRecipient)Children[index];
        //}

        //public PersonRecipient this[int index]
        //{
        //    get { return (PersonRecipient)Children[index]; }
        //}

        //public int GetChildrenNumber()
        //{
        //    return Children.Count;
        //}

        //#endregion

        //#region IEnumerable Members

        //public IEnumerator GetEnumerator()
        //{
        //    return Children.GetEnumerator();
        //}

        //#endregion
    }
}
