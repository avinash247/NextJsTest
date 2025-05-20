using Microsoft.EntityFrameworkCore;
using ReactTestApp.Server.Models;

namespace ReactTestApp.Server.DataLayer
{
    public class TradeAPIDbContext : DbContext
    {
        public TradeAPIDbContext(DbContextOptions<TradeAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<TradingData> TradingData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradingData>()
                .HasKey(td => td.OrderId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
