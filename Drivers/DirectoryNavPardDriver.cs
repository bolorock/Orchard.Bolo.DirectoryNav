using Orchard.ContentManagement.Drivers;
using Bolo.DirectoryNav.Models;
using Bolo.DirectoryNav.ViewModels;
using Orchard.Localization;
using Orchard.ContentManagement;

namespace Bolo.DirectoryNav.Drivers
{
    public class DirectoryNavPardDriver : ContentPartDriver<DirectoryNavPard>
    {
        public Localizer T { get; set; }

        protected override string Prefix
        {
            get
            {
                return "DirectoryNav";
            }
        }

        protected override DriverResult Display(DirectoryNavPard part, string displayType, dynamic shapeHelper)
        {
            DirectoryNavViewModel viewModel=new DirectoryNavViewModel();
            return ContentShape("Parts_DirectoryNav",
                () => shapeHelper.DisplayTemplate(
                    TemplateName:"Parts.DirectoryNav",
                    Model:viewModel,
                    Prefix:Prefix
                    ));
        }

                //GET
        //protected override DriverResult Editor(DirectoryNavPard part, dynamic shapeHelper) {
        //    return ContentShape("Parts_ImageGallery_Edit",
        //                        () => shapeHelper.EditorTemplate(
        //                            TemplateName: "Parts/ImageGallery",
        //                            Model: part,
        //                            Prefix: Prefix));
        //}

        ////POST
        //protected override DriverResult Editor(DirectoryNavPard part, IUpdateModel updater, dynamic shapeHelper) {
        //    updater.TryUpdateModel(part, Prefix, null, null);
        //    return Editor(part, shapeHelper);
        //}
    }
}