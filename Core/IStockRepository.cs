using pfs.Core.model;
using System.Threading.Tasks;
namespace pfs.Core
{
    public interface IStockRepository
    {
        void addNewStock(Stock stock);
        void removeStock(Stock stock);
        void updateStock(Stock stock);
        Task<Stock> GetStockAsync(string StockCode);
        bool CheckStockExist(string StockCode);
    }
}