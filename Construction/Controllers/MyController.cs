using Microsoft.AspNetCore.Mvc;

namespace Construction.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
    }
}
