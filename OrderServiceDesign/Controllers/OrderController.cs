using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderServiceDesign.BusinessLayer.Interface;
using OrderServiceDesign.Domain.DTO;
using OrderServiceDesignAPI.CommandQuery;

namespace OrderServiceDesignAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService {  get; set; }
        IMediator _mediator;
        public OrderController(IOrderService orderService, IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDetailDTO orderDetailDTO)
        {
            bool result = await _mediator.Send(new CreateOrderDetailsCommand() { orderDetailDTO = orderDetailDTO });
            return Ok();
        }

        [HttpDelete]
        [Route("{orderId}")]
        public async Task<IActionResult> DeleteOrder(int orderId)
        {
            bool result = await _mediator.Send(new DeleteOrderDetailsCommand() { orderId = orderId });
            return Ok();
        }
    }
}
