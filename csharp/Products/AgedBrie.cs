namespace csharp.Products
{
    class AgedBrie : NormalProduct
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += item.SellIn <= 0 ? 2 : 1;
            }
        }
    }


}
