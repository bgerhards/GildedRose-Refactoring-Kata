namespace csharp.Products
{
    class Conjured : IProduct
    {
        public bool IsProductType(Item item)
        {
            return item.Name.StartsWith("Conjured");
        }

        public void UpdateQualityAndSellIn_Daily(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality += item.SellIn == 0 ? -4 : -2;
            }
            item.SellIn--;
        }


    }
}
