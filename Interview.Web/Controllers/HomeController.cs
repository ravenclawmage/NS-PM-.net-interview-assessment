using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult ViewContacts()
        {
            return PartialView("ContactGrid");
        }

        public ActionResult CreateContact()
        {
            return PartialView("ContactForm");
        }
    }
}