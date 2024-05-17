using LuxGamingShop.Models;

namespace LuxGamingShop.ViewModels
{
    public class HomeIndexVM
    {
        public List<Feature> Features { get; set; }

        public List<Gaming> Gamings { get; set; }
        public List<Trending> Trendings { get; set; }
        public List<Banner> Banners { get; set; }

    }
}
