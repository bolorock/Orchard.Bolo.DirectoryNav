using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bolo.DirectoryNav.ViewModels
{
    public class LinkAddViewModel
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string LinkName { get; set; }
        public string Url { get; set; }
    }
}