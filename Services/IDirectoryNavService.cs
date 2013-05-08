using System.Collections.Generic;
using Orchard;

using Bolo.DirectoryNav.Models;

namespace Bolo.DirectoryNav.Services
{
    public interface IDirectoryNavService : IDependency
    {
        IEnumerable<TitleRecord> GetTitles();
        IEnumerable<Headline> GetHeadlines();

        IEnumerable<string> AllowedFileFormats { get; }

        Models.Headline GetHeadline(int titleId);

        void CreateTitle(string titleName);
        void DeleteTitle(int titleId);
        void EditTitle(TitleRecord record);
        //void UpdateImageGalleryProperties(string name, int thumbnailHeight, int thumbnailWidth, bool keepAspectRatio);

        LinkRecord GetLink(int linkId);
        void AddLink(int titleId, string linkName, string url);
        void EditLink(LinkRecord record);
        void DeleteLink(int linkId);

        //string GetPublicUrl(string path);
        // bool IsFileAllowed(HttpPostedFileBase file);

        void ReorderLinks(string titleName, IEnumerable<string> links);
    }
}