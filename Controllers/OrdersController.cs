using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOLID_Refactoring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public Services.OrderService _orderService;
        public OrdersController(Services.OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Orders API is running");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Order details for order id: {id}");
        }

        [HttpGet]
        [Route("customer/{customerId}")]
        public IActionResult GetByCustomer(int customerId)
        {
            return Ok($"Orders for customer id: {customerId}");
        }

        [HttpGet]
        [Route("status/{status}")]
        public IActionResult GetByStatus(string status)
        {
            return Ok($"Orders with status: {status}");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.Order order)
        {
            try
            {
                _orderService.PlaceOrder(order);
                return Ok("Order placed successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
