using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bolo.DirectoryNav.ViewModels
{
    public class DirectoryNavIndexViewModel
    {
        public DirectoryNavIndexViewModel()
        {
            Headlines = new List<Models.Headline>();
        }

        public IEnumerable<Models.Headline> Headlines { get; set; }
    }
}