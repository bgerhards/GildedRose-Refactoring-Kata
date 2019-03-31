using csharp.Products;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<IProduct> _products;
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            _products = new List<IProduct>();
            _products.Add(new BackstagePass());
            _products.Add(new AgedBrie());
            _products.Add(new Sulfuras());
            _products.Add(new Conjured());
            _products.Add(new Product());

            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                foreach (var product in _products)
                {
                    if (product.IsProductType(item))
                    {
                        product.UpdateQualityAndSellIn_Daily(item);
                        break;
                    }
                }
            }
        }
    }
}
