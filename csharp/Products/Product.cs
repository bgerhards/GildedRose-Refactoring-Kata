namespace csharp.Products
{
    class Product : IProduct
    {
        public virtual bool IsProductType(Item item)
        {
            return true;
        }

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
