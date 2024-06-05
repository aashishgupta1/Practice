using MediatR;
using OrderServiceDesign.BusinessLayer.Interface;

namespace OrderServiceDesignAPI.CommandQuery
{
    public class DeleteOrderDetailsCommand: IRequest<bool>
    {
        public int orderId { get; set; }
    }
    public class DeleteOrderDetailsHandler : IRequestHandler<DeleteOrderDetailsCommand,bool>
    {
        IOrderService _orderService;
        public DeleteOrderDetailsHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<bool> Handle(DeleteOrderDetailsCommand request, CancellationToken cancellationToken)
        {
            bool result = await _orderService.DeleteOrder(request.orderId);
            return result;
        }
    }
}
