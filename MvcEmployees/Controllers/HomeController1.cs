using Microsoft.AspNetCore.Mvc;

namespace MvcEmployees.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
