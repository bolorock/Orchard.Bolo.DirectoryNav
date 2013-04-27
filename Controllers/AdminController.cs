using System;
using System.Web.Mvc;
using Orchard;
using Orchard.Localization;
using Orchard.UI.Notify;

using Bolo.DirectoryNav.ViewModels;
using Bolo.DirectoryNav.Services;


namespace Bolo.DirectoryNav.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDirectoryNavService _directoryNavService;
        public IOrchardServices _orchardServices { get; set; }
        public Localizer T { get; set; }


        public AdminController(IOrchardServices orchardService, IDirectoryNavService directoryNavService)
        {
            _orchardServices = orchardService;
            _directoryNavService = directoryNavService;

            T = NullLocalizer.Instance;
        }

        [HttpGet]
        public ViewResult index()
        {
            return View(new DirectoryNavIndexViewModel { Headlines = _directoryNavService.GetHeadlines() });
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageDirectoryNav, T("Couldn't create DirectoryNav Title")))
            {
                return new HttpUnauthorizedResult();
            }

            return View(new CreateTitleViewModel());
        }

        [HttpPost]
        public ActionResult Create(CreateTitleViewModel addTitleViewModel)
        {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageDirectoryNav, T("Couldn't create DirectoryNav Title")))
            {
                return new HttpUnauthorizedResult();
            }
            if (!ModelState.IsValid)
            {
                return View(addTitleViewModel);
            }

            try
            {
                _directoryNavService.CreateTitle(addTitleViewModel.TitleName);

                _orchardServices.Notifier.Information(T("Title created"));
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                _orchardServices.Notifier.Error(T("Creating Title failed: {0}", exception.Message));
                return View(addTitleViewModel);
            }
        }

        [HttpGet]
        public ActionResult Links(int titleId)
        {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageDirectoryNav, T("Cannot edit image gallery")))
            {
                return new HttpUnauthorizedResult();
            }

            var headline = _directoryNavService.GetHeadline(titleId);

            return View(new LinkViewModel
            {
                TitleId = headline.TitleId,
                TitleName = headline.Name,
                Links = headline.links
            });
        }

        [HttpGet]
        public ActionResult AddLinks(int titleId, string titleName)
        {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageDirectoryNav, T("Cannot add links to title")))
            {
                return new HttpUnauthorizedResult();
            }

            return View(new LinkAddViewModel { TitleId = titleId, TitleName = titleName });
        }

        [HttpPost]
        public ActionResult AddLinks(LinkAddViewModel viewModel)
        {
            if (!_orchardServices.Authorizer.Authorize(Permissions.ManageDirectoryNav, T("Couldn't add link")))
            {
                return new HttpUnauthorizedResult();
            }

            if (!ModelState.IsValid)
                return View(viewModel);

            try
            {
                _directoryNavService.AddLInk(viewModel.TitleId, viewModel.LinkName, viewModel.Url);

                _orchardServices.Notifier.Information(T("Title created"));
                return RedirectToAction("Index");

            }
            catch (Exception exception)
            {
                _orchardServices.Notifier.Error(T("Adding link failed: {0}", exception.Message));
                return View(viewModel);
            }

            return RedirectToAction("Links", new { titleId=viewModel.TitleId, TitleName= viewModel.TitleName });
        }
    }
}