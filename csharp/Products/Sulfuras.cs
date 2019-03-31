namespace csharp.Products
{
    class Sulfuras : IProduct
    {
        public bool IsProductType(Item item)
        {
            return item.Name.StartsWith("Sulfuras");
        }

        public void UpdateQualityAndSellIn_Daily(Item item)
        {}
    }
}
