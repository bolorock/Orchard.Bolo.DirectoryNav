using System.Collections.Generic;
using Bolo.DirectoryNav.Models;

namespace Bolo.DirectoryNav.ViewModels
{
    public class LinkViewModel
    {
        public IEnumerable<Link> Links { get; set; }

        public string TitleName { get; set; }

        public int TitleId { get; set; }
    }
}