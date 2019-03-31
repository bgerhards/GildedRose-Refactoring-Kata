namespace csharp.Products
{
    class AgedBrie : IProduct
    {
        public bool IsProductType(Item item)
        {
            return item.Name.EndsWith("Aged Brie");
        }

        public void UpdateQualityAndSellIn_Daily(Item item)
        {
            if (item.Quality < 50)
            {
                if (item.SellIn < 1)
                {
                    item.Quality += 2;
                }
                else
                {
                    item.Quality++;
                }
            }

            item.SellIn--;
        }
    }
}
