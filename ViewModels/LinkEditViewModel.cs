using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bolo.DirectoryNav.ViewModels
{
    public class LinkEditViewModel
    {
        public int LinkId { get; set; }
        public string LinkName { get; set; }
        public string Url { get; set; }
        public int TitleId { get; set; }
        public string TitleName { get; set; }
    }
}