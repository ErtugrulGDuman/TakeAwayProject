namespace TakeAwayProject.SignalRApi.DAL
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string Product { get; set; }
        public string Status { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
