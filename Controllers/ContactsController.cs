using Microsoft.AspNetCore.Mvc;
using WebApplicationTestProject.Models;

namespace WebApplicationTestProject.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
