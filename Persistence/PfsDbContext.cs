using Microsoft.EntityFrameworkCore;
using pfs.Core.model;

namespace pfs.Persistence
{
    public class PfsDbContext : DbContext
    {
        public PfsDbContext(DbContextOptions<PfsDbContext> options) : base(options)
        {

        }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<AccountHistory> AccountHistory { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<ExchangeRate> ExchangeRate { get; set; }

    }

}