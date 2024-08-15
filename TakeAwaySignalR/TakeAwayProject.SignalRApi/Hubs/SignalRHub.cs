using Microsoft.AspNetCore.SignalR;
using TakeAwayProject.SignalRApi.DAL;

namespace TakeAwayProject.SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly Context _context;

        public SignalRHub(Context context)
        {
            _context = context;
        }

        public async Task TotalDeliveryCount()
        {
            var value = _context.Deliveries.Count();
            await Clients.All.SendAsync("ReciveTotalDeliveryCount", value);

            var value4 = _context.Deliveries.Where(x => x.Status == "Teslim Edildi").Count();
            await Clients.All.SendAsync("ReciveTotalDeliveryCountStatusByDelivered", value4);
        }
        public async Task TotalDeliveryCountStatusByOnWay()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Yolda").Count();
            await Clients.All.SendAsync("ReciveTotalDeliveryCountStatusByOnWay", value);
        }
        public async Task TotalDeliveryCountStatusByGettingReady()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Hazirlaniyor").Count();
            await Clients.All.SendAsync("ReciveTotalDeliveryCountStatusByGettingReady", value);
        }
        public async Task GetDeliveryList()
        {
            var value = _context.Deliveries.ToList();
            await Clients.All.SendAsync("ReciveDeliveryList", value);
        }
    }
}
