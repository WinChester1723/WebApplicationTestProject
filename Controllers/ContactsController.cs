using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTestProject.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
