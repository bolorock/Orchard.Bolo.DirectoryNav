using Orchard.UI.Resources;

namespace Bolo.DirectoryNav
{
    public class ResourceManifest:IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            builder.Add().DefineStyle("DirectoryNav").SetUrl("bolo-directoryNav.css");          
        }
    }
}