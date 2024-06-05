using OrderServiceDesign.Domain.BaseDetail;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderServiceDesign.Domain.Entities
{
    public class OrderDetails : BaseEntity
    {
        public List<BasketItem> BasketItems { get; set; }
        public string BuyerId { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        
        public int ShippingDetailsId { get; set; }
        public virtual Address Address { get; set; }
        public virtual ShippingDetails ShippingDetails {  get; set; }
    }
}
