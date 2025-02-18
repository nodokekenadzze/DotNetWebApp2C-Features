namespace LanguageFeatures.Models
{
    // Product class represents a product with a name and price
    public class Product
    {
        public string Name { get; set; } = string.Empty; // Product name
        public decimal? Price { get; set; } // Product price, can be null

        // The GetProducts method returns an array of sample products
        public static Product?[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            // Returns an array of products with one null product included
            return new Product?[] { kayak, lifejacket, null };
        }
    }
}
