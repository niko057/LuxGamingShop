﻿using LuxGamingShop.Models;
using LuxGamingShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var features = new List<Feature>();
            features.Add(new Feature { Id = 1, Title = "free storage1", Path = "featured-01.png" });
            features.Add(new Feature { Id = 2, Title = "user more2", Path = "featured-02.png" });
            features.Add(new Feature { Id = 3, Title = "reply ready3", Path = "featured-03.png" });
            features.Add(new Feature { Id = 4, Title = "easy layout4", Path = "featured-04.png" });


            var gaming = new List<Gaming>();
            gaming.Add(new Gaming { Id = 1, Tittle = "Warframe", Path = "top-game-01.jpg", CategoriesName = "Adventure" });
            gaming.Add(new Gaming { Id = 2, Tittle = "BatleGrounds", Path = "top-game-02.jpg", CategoriesName = "Pubg" });
            gaming.Add(new Gaming { Id = 3, Tittle = "Apex", Path = "top-game-03.jpg", CategoriesName = "Assasin1" });
            gaming.Add(new Gaming { Id = 4, Tittle = "Sims", Path = "top-game-04.jpg", CategoriesName = "Assasin2" });
            gaming.Add(new Gaming { Id = 5, Tittle = "Lostark", Path = "top-game-05.jpg", CategoriesName = "AssasinLostark" });

            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Features = features;
            homeIndexVM.Gamings = gaming;

            return View(homeIndexVM);


        }



    }


}
