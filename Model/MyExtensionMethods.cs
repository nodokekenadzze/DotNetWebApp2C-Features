namespace LanguageFeatures.Models
{
    // Static class to hold extension methods for Product IEnumerable
    public static class MyExtensionMethods
    {
        // Extension method to calculate the total price of all products in the IEnumerable
        public static decimal TotalPrices(this IEnumerable<Product?> products)
        {
            decimal total = 0;
            foreach (Product? prod in products)
            {
                // Adds the product price if it's not null, otherwise adds 0
                total += prod?.Price ?? 0;
            }
            return total;
        }

        // Extension method to filter products by price, returns those greater than or equal to the specified minimum price
        public static IEnumerable<Product?> FilterByPrice(
            this IEnumerable<Product?> productEnum, decimal minimumPrice)
        {
            foreach (Product? prod in productEnum)
            {
                // Checks if the product price is greater than or equal to the minimum price
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod; // Returns the product that matches the condition
                }
            }
        }

        // Extension method to filter products based on a predicate (custom condition)
        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> productEnam,
            Func<Product?, bool> selector)
        {
            foreach (Product? prod in productEnam)
            {
                // Filters based on the condition passed through the selector function
                if (selector(prod))
                {
                    yield return prod; // Returns the product that matches the condition
                }
            }
        }
    }
}