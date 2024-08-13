using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayProject.SignalRApi.DAL;

namespace TakeAwayProject.SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }
        [HttpGet("TotalDeliveryCount")]
        public IActionResult TotalDeliveryCount()
        {
            var value = _context.Deliveries.Count();
            return Ok(value);
        }
        [HttpGet("TotalDeliveryCountStatusByOnWay")]
        public IActionResult TotalDeliveryCountStatusByOnWay()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Yolda").Count();
            return Ok(value);
        }
        [HttpGet("TotalDeliveryCountStatusByGettingReady")]
        public IActionResult TotalDeliveryCountStatusByGettingReady()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Hazirlaniyor").Count();
            return Ok(value);
        }
    }
}
