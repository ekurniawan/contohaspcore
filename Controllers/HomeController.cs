using Microsoft.AspNetCore.Mvc;

namespace contohaspcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return Content("Hello from Controller !");
        }

        public IActionResult About(){
            return Content("About Page");
        }
    }
}