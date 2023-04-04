using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VisionX.Model;

namespace VisionX.Controllers
{
    public class OrderBookController : Controller
    {
        [HttpGet("GetOrderBook")]
        public async Task<OrderBook> GetOrderBook()
        {
            //ValrProxy varProxy = new ValrProxy(String.Empty,String.Empty);
            //var jsonstring = await varProxy.GetVal("BTCZAR");
            //var result = JsonConvert.DeserializeObject<OrderBook>(jsonstring);
            return new OrderBook();
        }
    }
}