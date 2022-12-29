using Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Empty.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name="Nike",
                    Price=123F,
                    Img="product-2.jpg",
                    Description="Nike satilir"
                }
            };
            new Product
            {
                Id = 2,
                Name = "Camera",
                Price = 137F,
                Img = "product-1.jpg",
                Description = "Camera satilir"
            };
            new Product
            {
                Id = 3,
                Name = "Helikopter",
                Price = 92F,
                Img = "product-5.jpg",
                Description = "Helikopter satilir"
            };

            return View(products);
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult ShopDetail()
        {
            return View();
        }
    }
}
