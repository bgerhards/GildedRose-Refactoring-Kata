namespace csharp.Products
{
    class AgedBrie : Product
    {
        override public bool IsProductType(Item item)
        {
            return item.Name.EndsWith("Aged Brie");
        }

        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += item.SellIn <= 0 ? 2 : 1;
            }
        }
    }


}
