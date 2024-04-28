namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(ProductItmeOrdered itmeOrdered, decimal price, int quantity)
        {
            ItmeOrdered = itmeOrdered;
            Price = price;
            Quantity = quantity;
        }

        public ProductItmeOrdered ItmeOrdered { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
