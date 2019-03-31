using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void UpdateQualityShouldDecreaseSellInAndQualityBy1WhenSellInAndQualityIsGreaterThan0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 4, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "foo", 3, 4);
        }

        [Test]
        public void UpdateQualityShouldDecreaseSellInAndQualityBy2WhenSellInIs0OrLess()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "foo", -1, 3);
        }

        [Test]
        public void QualityWillNeverBeLessThan0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "foo", -1, 0);
        }

        [Test]
        public void AgedBrieIncreasesInQualityWithEachUpdate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Aged Brie", 4, 6);
        }

        [Test]
        public void AgedBrieIncreasesInQualityBy2WithSellInDate0OrLess()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 8 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Aged Brie", -1, 10);
        }

        [Test]
        public void QualityOfATypicalItemNeverExceeds50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Aged Brie", 4, 50);
        }

        [Test]
        public void QualityAndSellInOfALegendaryItemNeverChanges()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 15, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Sulfuras, Hand of Ragnaros", 15, 80);
        }

        [Test]
        public void BackstagePassesIncreaseInQualityBy1WhenSellInIsGreaterThan10Days()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Backstage passes to a TAFKAL80ETC concert", 10, 21);
        }

        [Test]
        public void BackstagePassesIncreaseInQualitBy2WhenSellInIsGreaterThan5AndLessThan11()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Backstage passes to a TAFKAL80ETC concert", 5, 22);
        }

        [Test]
        public void BackstagePassesIncreaseInQualitBy3WhenSellInIsGreaterThan0AndLessThan6()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Backstage passes to a TAFKAL80ETC concert", 1, 23);
        }

        [Test]
        public void BackstagePassesLosesAllQualityWhenSellIn0OrLess()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Backstage passes to a TAFKAL80ETC concert", -1, 0);
        }

        private void AssertItem(Item item, string itemName, int itemSellIn, int itemQuality)
        {
            Assert.AreEqual(itemName, item.Name);
            Assert.AreEqual(itemQuality, item.Quality);
            Assert.AreEqual(itemSellIn, item.SellIn);
        }
    }
}
