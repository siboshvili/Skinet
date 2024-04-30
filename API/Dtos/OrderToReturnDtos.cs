


using Core.Entities.OrderAggregate;

namespace API.Dtos
{
    public class OrderToReturnDtos
    {
        public int Id { get; set; }

        public string BuyerEmail { get; set; }

        public DateTime OrderDate { get; set; }

        public Address ShipToAddress { get; set; }

        public string DeliveryMethod { get; set; }

        public IReadOnlyList<OrderItemDto> OrderItems { get; set; }

        public decimal Subtotal { get; set; }

        public string Total { get; set; }

        public string Status { get; set; }
    }
}
