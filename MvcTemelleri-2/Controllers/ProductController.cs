using Microsoft.AspNetCore.Mvc;
using MvcTemelleri_2.Models;

namespace MvcTemelleri_2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult list()
        {
            var product = new List<Product>
            { 
                new Product{Id=1,Name="Laptop",Price=999.99m},
                new Product{Id=2,Name="Iphone",Price=499.56m},
                new Product{Id=3,Name="Tablet",Price=250.00m}

            };


            return Json(product);
        }
    }
}
