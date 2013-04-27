using Orchard.Localization;
using Orchard.UI.Navigation;

namespace Bolo.DirectoryNav
{
    public class AdminMenu : INavigationProvider
    {
        public Localizer T { get; set; }

        public AdminMenu()
        {
            T = NullLocalizer.Instance;
        }

        public string MenuName
        {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("imagegallery")
              .Add(T("Directory Nav"), "7",
                          menu => menu.Add(T("Directory Nav"), "0", item => item.Action("Index", "Admin", new { area = "Bolo.DirectoryNav" })
                                                                                .Permission(Permissions.ManageDirectoryNav)));
        }
    }
}