using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Bolo.DirectoryNav.Models
{
    public class DirectoryNavPard : ContentPart<TitleRecord>
    {
        public string Name
        {
            get { return Record.Name; }
            set { Record.Name = value; }
        }

        public IList<LinkRecord> Linkrecords
        {
            get { return Record.LinkRecords; }
            set { Record.LinkRecords = value; }
        }
    }
}