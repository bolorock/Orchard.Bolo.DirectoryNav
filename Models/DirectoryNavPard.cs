using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Bolo.DirectoryNav.Models
{
    public class DirectoryNavPard : ContentPart<TitlePardRecord>
    {
        public string Name
        {
            get { return Record.Name; }
            set { Record.Name = value; }
        }

        public IList<LinkRecord> Linkrecords
        {
            get { return Record.LinkPardRecords; }
            set { Record.LinkPardRecords = value; }
        }
    }
}