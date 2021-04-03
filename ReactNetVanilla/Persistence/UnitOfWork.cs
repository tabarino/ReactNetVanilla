using System;
using System.Threading.Tasks;
using ReactNetVanilla.Core;

namespace ReactNetVanilla.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ReactNetDbContext _context;

        public UnitOfWork(ReactNetDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
