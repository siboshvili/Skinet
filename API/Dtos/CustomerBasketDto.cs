using System.ComponentModel.DataAnnotations;
using Core.Entities;

namespace API.Dtos
{
    public class CustomerBasketDto
    {

        [Required]
        public string Id { get; set; }

        public List<BasketItem> Items { get; set; } = new List<BasketItem>();

        public int? DeliveryMethodId { get; set; }

        public string ClientSecret { get; set; }

        public string PaymentIntentId { get; set; }
    }
}
