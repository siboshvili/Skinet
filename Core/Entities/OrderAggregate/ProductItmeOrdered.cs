namespace Core.Entities.OrderAggregate
{
    public class ProductItmeOrdered
    {
        public ProductItmeOrdered()
        {
        }

        public ProductItmeOrdered(int productItemId, string productName, string pictureUrl)
        {
            ProductItemId = productItemId;
            ProductName = productName;
            PictureUrl = pictureUrl;
        }

        public int ProductItemId { get; set; }

        public string ProductName { get; set; }

        public string PictureUrl { get; set; }
    }
}
