namespace API.Dtos
{
    public class OrderDto
    {
        public string basketId { get; set; }

        public int DeliveryMethodId { get; set; }

        public AddressDto ShipAddress { get; set; }
    }
}
