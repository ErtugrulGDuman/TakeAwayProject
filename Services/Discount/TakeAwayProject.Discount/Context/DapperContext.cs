using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TakeAwayProject.Discount.Entities;

namespace TakeAwayProject.Discount.Context
{
    public class DapperContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Key");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EGD\\SQLEXPRESS;initial catalog=TakeAwayProjectDiscountDb;integrated security=true");
        }
        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }
        private readonly string _connectionString;
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
