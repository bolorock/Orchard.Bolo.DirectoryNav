using System.Collections.Generic;
using Orchard.ContentManagement.Records;

namespace Bolo.DirectoryNav.Models
{
    public class TitleRecord 
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<LinkRecord> LinkRecords { get; set; }
    }
}