using csharp.Products;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly ProductFactory _productFactory;
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            _productFactory = new ProductFactory();
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                _productFactory
                    .GetProductByName(item.Name)
                    .UpdateQualityAndSellIn_Daily(item);
            }
        }
    }
}
