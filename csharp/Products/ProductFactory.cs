using System.Collections.Generic;
using csharp.Products;
using System.Linq;

interface IProductFactory
{
    IProduct GetProductByName(string name);
}

namespace csharp.Products
{
    class ProductFactory : IProductFactory
    {
        private readonly Dictionary<string, IProduct> _products;
        public ProductFactory()
        {
            _products = new Dictionary<string, IProduct> {
                { "Aged Brie", new AgedBrie() },
                { "Backstage passes to a TAFKAL80ETC concert", new BackstagePass() },
                { "Sulfuras", new Product() },
                { "Conjured", new Conjured() }
            };
        }
        public IProduct GetProductByName(string name)
        {
            var matching = _products.Keys.Where(key => name.StartsWith(key));
            return matching.Count() > 0 ? _products[matching.First()] : new NormalProduct();
        }
    }
}
