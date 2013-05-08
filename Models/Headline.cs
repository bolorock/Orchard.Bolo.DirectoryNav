using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bolo.DirectoryNav.Models
{
    public class Headline
    {
        public Headline()
        {
            links = new List<LinkRecord>();
        }

        public int TitleId { get; set; }
        public string Name { get; set; }
        public int linkNum { get; set; }
        public DateTime LastUpdated { get; set; }

        public int row { get; set; }
        public int column { get; set; }

        public IEnumerable<LinkRecord> links { get; set; }
    }
}