using System.Collections.Generic;
using Orchard.ContentManagement.Records;

namespace Bolo.DirectoryNav.Models
{
    public class TitlePardRecord : ContentPartRecord
    {
        public virtual string Name { get; set; }
        public virtual IList<LinkRecord> LinkPardRecords { get; set; }
    }
}