using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bolo.DirectoryNav.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
        }

        [HttpGet]
        public ViewResult index()
        {
            return View();
        }
    }
}