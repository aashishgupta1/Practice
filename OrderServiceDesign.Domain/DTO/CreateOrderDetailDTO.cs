using OrderServiceDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.Domain.DTO
{
    public class CreateOrderDetailDTO
    {
        public List<BasketItemDTO> BasketItems { get; set; }
        public int AddressId { get; set; }
    }
}
