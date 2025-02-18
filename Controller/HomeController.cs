
using System.Collections.Generic;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // The below code is commented-out, it is an example of a potential name filter
        //bool FilterByPrice(Product? p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        // The below code is also commented-out, it demonstrates how you might filter by product name and return just the names
        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        public ViewResult Index()
        {
            // Create a shopping cart with a list of products
            ShoppingCart cart = new() { Products = Product.GetProducts() };

            // Create an array of products with different prices
            Product[] productArray =
                {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
                };

            // Filters the products by price (greater than or equal to 20) and calculates the total price
            decimal priceFilterTotal = productArray
                .Filter(p => (p?.Price ?? 0) >= 20)
                .TotalPrices();

            // Filters the products by name starting with 'S' and calculates the total price
            decimal nameFilterTotal = productArray
                .Filter(p => p?.Name?[0] == 'S')
                .TotalPrices();

            // Returns the view with the results for both filters, formatted as currency
            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
        }
    }
}