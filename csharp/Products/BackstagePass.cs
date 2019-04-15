namespace csharp.Products
{
    class BackstagePass : NormalProduct
    {
        public override void UpdateQuality(Item item)
        {
            item.Quality = item.SellIn > 0
                ? GetNewQuality(item.Quality, item.SellIn)
                : item.Quality - item.Quality;
        }

        private int GetNewQuality(int quality, int sellIn)
        {
            int newItemQuality = quality;
            if (sellIn > 10)
            {
                newItemQuality++;
            }
            else if (sellIn > 5)
            {
                newItemQuality += 2;
            }
            else
            {
                newItemQuality += 3;
            }
            return newItemQuality <= 50 ? newItemQuality : 50;
        }
    }
}
