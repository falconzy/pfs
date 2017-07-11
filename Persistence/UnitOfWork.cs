using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pfs.Persistence
{
    public class UnitOfWork
    {
        private readonly PfsDbContext _context;

        public UnitOfWork(PfsDbContext context)
        {
            _context = context;
        }
        
        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
