using LuxGamingShop.Models;
using LuxGamingShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dbContext;
        public HomeController(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

       

        public IActionResult Index()
        {
            
            var features = _dbContext.Features.ToList();

            var gaming = _dbContext.Gamings.ToList();

            var banner= _dbContext.Banners.ToList();

            var trending= _dbContext.Trendings.ToList();
            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Features = features;
            homeIndexVM.Gamings = gaming;
            homeIndexVM.Banners = banner;
            homeIndexVM.Trendings= trending;



            return View(homeIndexVM);


        }



    }


}
