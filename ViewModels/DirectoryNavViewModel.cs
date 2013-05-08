using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bolo.DirectoryNav.Models;

namespace Bolo.DirectoryNav.ViewModels
{
    public class DirectoryNavViewModel
    {
        public DirectoryNavViewModel()
        {
            Titles = new List<TitleRecord>();
        }
       public IEnumerable<TitleRecord> Titles{get;set;}
    }
}