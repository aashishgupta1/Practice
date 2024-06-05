using OrderServiceDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.Domain.DTO
{
    public class CustomerCartDTO
    {
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; } = [];
    }
}
