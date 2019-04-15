namespace csharp.Products
{
    class Conjured : NormalProduct
    {
        override public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality += item.SellIn <= 0 ? -4 : -2;
            }
        }


    }
}
