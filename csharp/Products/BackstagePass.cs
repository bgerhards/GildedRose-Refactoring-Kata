namespace csharp.Products
{
    class BackstagePass : IProduct
    {
        public bool IsProductType(Item item)
        {
            return item.Name.Equals("Backstage passes to a TAFKAL80ETC concert");
        }

        public void UpdateQualityAndSellIn_Daily(Item item)
        {
            if (item.SellIn > 0 && item.Quality < 50)
            {
                if (item.SellIn > 10)
                {
                    item.Quality++;
                }
                else if (item.SellIn > 5)
                {
                    item.Quality += 2;
                }
                else
                {
                    item.Quality += 3;
                }
            }

            if (item.SellIn == 0)
            {
                item.Quality = 0;
            }

            if (item.Quality > 50) item.Quality = 50;

            item.SellIn--;
        }
    }
}
