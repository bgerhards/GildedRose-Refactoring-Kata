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
            AssertItem(item, "foo", 4, 3);
        }

        [Test]
        public void UpdateQualityShouldDecreaseSellInAndQualityBy2WhenSellInIs0OrLess()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "foo", 3, -1);
        }

        [Test]
        public void QualityWillNeverBeLessThan0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "foo", 0, -1);
        }

        [Test]
        public void AgedBrieIncreasesInQualityWithEachUpdate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Aged Brie", 6, 4);
        }

        [Test]
        public void QualityOfATypicalItemNeverExceeds50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            var item = Items[0];
            AssertItem(item, "Aged Brie", 50, 4);
        }

        private void AssertItem(Item item, string itemName, int itemQuality, int itemSellIn)
        {
            Assert.AreEqual(itemName, item.Name);
            Assert.AreEqual(itemQuality, item.Quality);
            Assert.AreEqual(itemSellIn, item.SellIn);
        }
    }
}
