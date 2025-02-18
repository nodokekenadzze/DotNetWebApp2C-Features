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
