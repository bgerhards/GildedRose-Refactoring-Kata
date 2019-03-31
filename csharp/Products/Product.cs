namespace csharp.Products
{
    class Product : IProduct
    {
        public bool IsProductType(Item item)
        {
            return true;
        }

        public virtual void UpdateQualityAndSellIn_Daily(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
            item.SellIn = item.SellIn - 1;


            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }
    }
}
