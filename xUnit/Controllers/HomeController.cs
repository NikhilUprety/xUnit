using Microsoft.AspNetCore.Mvc;

namespace xUnit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
