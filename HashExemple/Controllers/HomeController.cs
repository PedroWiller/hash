using Microsoft.AspNetCore.Mvc;

namespace HashExemple.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
