using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pfs.Core;
using pfs.Core.model;

namespace pfs.Persistence
{
    public class StockRepository : IStockRepository
    {
        private readonly PfsDbContext _context;

        public StockRepository(PfsDbContext Context)
        {
            _context = Context;
        }

        public void addNewStock(Stock stock)
        {
            _context.Stock.Add(stock);
        }

        public bool CheckStockExist(string StockCode)
        {
            var ValidStock = _context.Stock.Select(C=>C.StockCode==StockCode);
            return (ValidStock.Count() > 0) ? true : false;

        }

        public async Task<Stock> GetStockAsync(string StockCode)
        {
            var stock = await _context.Stock.FindAsync(StockCode);
            return stock;
        }

        public void removeStock(Stock stock)
        {
            _context.Stock.Remove(stock);

        }

        public void updateStock(Stock stock)
        {
            _context.Stock.Update(stock);
        }
    }
}
