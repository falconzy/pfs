using Microsoft.EntityFrameworkCore;
using pfs.Core.model;

namespace pfs.Persistence
{
    public class PfsDbContext : DbContext
    {
        public PfsDbContext(DbContextOptions<PfsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           
        }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<AccountHistory> AccountHistory { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<ExchangeRate> ExchangeRate { get; set; }
        public DbSet<MonthlySummary> MonthlySummary { get; set; }
        public DbSet<Spending> Spending { get; set; }
        public DbSet<SpendingType> SpendingType { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }


    }

}