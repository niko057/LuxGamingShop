using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
