using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderServiceDesign.BusinessLayer.Interface;
using OrderServiceDesign.Domain.DTO;
using OrderServiceDesign.Logger;
using OrderServiceDesignAPI.CommandQuery;


namespace OrderServiceDesignAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        ILoggerBase _logger;
        IMediator _mediator;
        public OrderController(IMediator mediator, ILoggerBase logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDetailDTO orderDetailDTO)
        {
            _logger.Information("CreateOrder method start");
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
