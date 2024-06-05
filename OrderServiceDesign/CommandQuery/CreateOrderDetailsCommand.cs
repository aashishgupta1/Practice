using MediatR;
using OrderServiceDesign.BusinessLayer.Interface;
using OrderServiceDesign.BusinessLayer.Service;
using OrderServiceDesign.Domain.DTO;

namespace OrderServiceDesignAPI.CommandQuery
{
    public class CreateOrderDetailsCommand : IRequest<bool>
    {
       public CreateOrderDetailDTO orderDetailDTO;
    }

    public class CreateOrderDetailsHandler : IRequestHandler<CreateOrderDetailsCommand, bool>
    {
        IOrderService _orderService;
        public CreateOrderDetailsHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<bool> Handle(CreateOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            bool result = await _orderService.CreateOrder(request.orderDetailDTO);
            return result;
        }
    }
}
