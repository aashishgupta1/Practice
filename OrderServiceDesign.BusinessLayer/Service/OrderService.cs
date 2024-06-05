using OrderServiceDesign.BusinessLayer.Interface;
using OrderServiceDesign.DataAccessLayer.Repository.Interface;
using OrderServiceDesign.Domain.DTO;
using OrderServiceDesign.NotificationBase.Strategy;

namespace OrderServiceDesign.BusinessLayer.Service
{
    public class OrderService: IOrderService
    {
        IOrderRepository _orderRepository;
        INotificationTypeContext _notificationTypeContext;
        public OrderService(IOrderRepository orderRepository, INotificationTypeContext notificationTypeContext )
        {
            _orderRepository = orderRepository;
            _notificationTypeContext = notificationTypeContext;
        }
        public async Task<bool> CreateOrder(CreateOrderDetailDTO orderDetailDTO)
        {
            var sms = _notificationTypeContext.GetNotificationTypeStrategy(EnumNotificationType.SMS);
            await sms.SendNotificationAsync("", "");
            var email = _notificationTypeContext.GetNotificationTypeStrategy(EnumNotificationType.Email);
            await email.SendNotificationAsync("", "");

            return await _orderRepository.CreateOrder(orderDetailDTO);
        }
        public async Task<bool> DeleteOrder(int orderId)
        {
            return await _orderRepository.DeleteOrder(orderId);
        }
    }
}