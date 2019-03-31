using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {

            foreach (var item in Items)
            {
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
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
                    continue;
                }
                if (item.Name == "Aged Brie")
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
                    continue;
                }
                if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    continue;
                }
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
}
