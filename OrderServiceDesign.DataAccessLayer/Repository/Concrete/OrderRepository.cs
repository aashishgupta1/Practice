using AutoMapper;
using OrderServiceDesign.DataAccessLayer.Repository.Interface;
using OrderServiceDesign.Domain.DTO;
using OrderServiceDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.DataAccessLayer.Repository.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        OrderDBContext _orderDBContext;
        IMapper _mapper;
        public OrderRepository(OrderDBContext orderDBContext, IMapper mapper)
        {
            _orderDBContext = orderDBContext;
            _mapper = mapper;
        }
        public async Task<bool> CreateOrder(CreateOrderDetailDTO orderDetailDTO)
        {
            var order = _mapper.Map<OrderDetails>(orderDetailDTO);
            _orderDBContext.OrderDetails.Add(order);
            await _orderDBContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteOrder(int orderId)
        {
            var order = _orderDBContext.OrderDetails.FirstOrDefault(x => x.Id == orderId);
            if (order == null || order.Id == 0)
            {
                return false;
            }
            _orderDBContext.OrderDetails.Remove(order);
            await _orderDBContext.SaveChangesAsync();
            return true;
        }
    }
}
