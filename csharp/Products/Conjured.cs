namespace csharp.Products
{
    class Conjured : Product
    {

        override public bool IsProductType(Item item)
        {
            return item.Name.StartsWith("Conjured");
        }

        override public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality += item.SellIn <= 0 ? -4 : -2;
            }
        }


    }
}
