using Microsoft.EntityFrameworkCore;

namespace TakeAwayProject.SignalRApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EGD\\SQLEXPRESS;initial Catalog=TakeAwayProjectDeliveryDb; integrated Security=true");
        }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
