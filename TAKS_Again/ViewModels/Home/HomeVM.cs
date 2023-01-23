using TAKS_Again.Models;

namespace TAKS_Again.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Product> FeaturedProducts { get; set; }
        public IEnumerable<Product> LastestProducts { get; set; }
    }
}
