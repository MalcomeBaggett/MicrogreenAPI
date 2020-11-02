using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MicrogreensTrayApi.Services;
using MicrogreensTrayApi.Models;
using MongoDB.Bson;
namespace MicrogreensTrayApi.Controllers
{

    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("api/Orders")]
        public ActionResult<List<Tray>> Get() => _orderService.Get();
        [HttpGet("api/Inventory")]
        public ActionResult<List<Tray>> GetInv() => _orderService.GetInv();
    }
}