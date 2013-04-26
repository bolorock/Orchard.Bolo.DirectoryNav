using Orchard.ContentManagement.Records;

namespace Bolo.DirectoryNav.Models
{
    public class LinkRecord
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual bool IsShow { get; set; }
    }
}