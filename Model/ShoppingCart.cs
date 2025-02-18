using System.Collections;

namespace LanguageFeatures.Models
{
    // ShoppingCart class represents a collection of products
    public class ShoppingCart : IEnumerable<Product?>
    {
        // List of products in the shopping cart (can be null)
        public IEnumerable<Product?>? Products { get; set; }

        // Returns an enumerator to iterate over the collection of products
        public IEnumerator<Product?> GetEnumerator() => Products?.GetEnumerator()
                ?? Enumerable.Empty<Product?>().GetEnumerator();

        // Required by IEnumerable, returns the enumerator for the collection
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}