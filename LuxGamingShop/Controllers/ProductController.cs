using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
