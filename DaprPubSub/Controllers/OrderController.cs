using System;
using Dapr;
using DaprPubSub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DaprPubSub.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
            
            _logger.LogInformation("OrderController initialised");
        }

        // NOTE: "pubsub" in the first argument is the default pub/sub configured by the Dapr CLI (which is shown in the dapr dashboard)
        [Topic("pubsub", "ordertopic")]
        [HttpPost("ordertopic")]
        public IActionResult ProcessOrder(Order order)
        {
            //Process order placeholder
            _logger.LogInformation($"ProcessOrder invoked on {DateTime.Now}");
            
            _logger.LogInformation($"Order processed: {order}");

            // throw new ApplicationException("Test exception");
            return Ok();
        }
    }
}