using OrderServiceDesign.Domain.BaseDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.Domain.Entities
{
    public class CustomerCart : BaseEntity
    {
        public string BuyerId { get; set; }

        public List<BasketItem> Items { get; set; } = [];
    }
}
