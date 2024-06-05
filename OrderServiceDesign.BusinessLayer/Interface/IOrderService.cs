using OrderServiceDesign.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.BusinessLayer.Interface
{
    public interface IOrderService
    {
        Task<bool> CreateOrder(CreateOrderDetailDTO orderDetailDTO);
        Task<bool> DeleteOrder(int orderId);
    }
}
