namespace csharp.Products
{
    class NormalProduct : IProduct
    {
        public void UpdateQualityAndSellIn_Daily(Item item)
        {
            UpdateQuality(item);
            UpdateSellIn(item);
        }

        public virtual void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality += item.SellIn <= 0 ? -2 : -1;
            }
        }

        public virtual void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }
    }
}
