namespace csharp.Products
{
    interface IProduct
    {
        bool IsProductType(Item item);
        void UpdateQualityAndSellIn_Daily(Item item);
    }
}
