using Ozbek.Bank.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Repository.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly OzbekBankDbContext _context;

        public UnitOfWork(OzbekBankDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
