using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 55000,
                    Description = "Powerful laptop for students"
                },

                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Price = 25000,
                    Description = "Modern smartphone with excellent features"
                },

                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Price = 2500,
                    Description = "Wireless headphones with good sound quality"
                },

                new Product
                {
                    Id = 4,
                    Name = "Keyboard",
                    Price = 1500,
                    Description = "Mechanical keyboard for programming"
                }
            };

            return View(products);
        }
    }
}