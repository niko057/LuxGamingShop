using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class SignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
