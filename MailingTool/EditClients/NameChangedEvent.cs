﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingTool
{
    class NameChangedEvent
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
