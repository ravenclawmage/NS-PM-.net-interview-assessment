using Interview.Web.DataAccess;
using System.Linq;
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
            using (var db = new ContactContext())
            {
                var model = db.Contacts.ToList();
                return PartialView("ContactGrid", model);
            }
        }

        public ActionResult CreateContact()
        {
            return PartialView("ContactForm");
        }

        public ActionResult SaveContact(Contact model)
        {
            if (!ModelState.IsValid) { return PartialView("ContactForm", model); }
            using (var db = new ContactContext())
            {
                db.Contacts.Add(model);
                db.SaveChanges();
            }
            return ViewContacts();
        }
    }
}