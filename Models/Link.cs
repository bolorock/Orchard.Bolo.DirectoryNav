using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bolo.DirectoryNav.Models
{
    public class Link
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsShow { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}