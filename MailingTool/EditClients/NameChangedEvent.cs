using System;

namespace MailingTool
{
    public class NameChangedEvent: EventArgs
    {
        public enum NameChangingKind { FirstName, LastName }

        public NameChangedEvent(string newName, NameChangingKind nameKind)
        {
            NewName = newName;
            NameKind = nameKind;
            Canceled = false;
        }

        public string NewName { get; set; }
        public bool Canceled { get; set; }

        NameChangingKind NameKind { get; set; }
    }
}
