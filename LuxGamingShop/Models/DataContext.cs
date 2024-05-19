using Microsoft.EntityFrameworkCore;

namespace LuxGamingShop.Models
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Gaming> Gamings { get; set; }
        public DbSet<Trending> Trendings { get; set; }
        
    }
}
