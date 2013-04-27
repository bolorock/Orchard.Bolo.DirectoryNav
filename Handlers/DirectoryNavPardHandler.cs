using Orchard.ContentManagement.Handlers;
using Bolo.DirectoryNav.Models;
using Orchard.Data;

namespace Bolo.DirectoryNav.Handlers
{
    public class DirectoryNavPardHandler : ContentHandler
    {
        public DirectoryNavPardHandler(IRepository<TitleRecord> repository)
        {
            //Filters.Add(StorageFilter.For(repository));
        }
    }
}