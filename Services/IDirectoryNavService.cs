using System.Collections.Generic;
using Orchard;

using Bolo.DirectoryNav.Models;

namespace Bolo.DirectoryNav.Services
{
    public interface IDirectoryNavService : IDependency
    {
        IEnumerable<Headline> GetHeadlines();

        IEnumerable<string> AllowedFileFormats { get; }

        Models.Headline GetHeadline(int titleId);

        void CreateTitle(string titleName);
        void DeleteTitle(string titleName);
        void RenameTitle(string titleName, string newName);
        //void UpdateImageGalleryProperties(string name, int thumbnailHeight, int thumbnailWidth, bool keepAspectRatio);

        Models.Link GetLink(string titleName, string linkName);
        void AddLInk(int titleId,string linkName, string url);
        //void UpdateImageProperties(string imageGalleryName, string imageName, string imageTitle, string imageCaption);
        void DeleteLink(string titleName, string linkName);

        //string GetPublicUrl(string path);
       // bool IsFileAllowed(HttpPostedFileBase file);

        void ReorderLinks(string titleName, IEnumerable<string> links);
    }
}