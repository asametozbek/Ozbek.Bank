using Microsoft.EntityFrameworkCore;
using Ozbek.Bank.Core.DTOs;
using Ozbek.Bank.Core.Models.Entity;
using Ozbek.Bank.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(OzbekBankDbContext context) : base(context)
        {
        }

        public async Task<User> CheckUser(LoginDto model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.IdentityNumber == model.IdentityNumber & x.Pin == model.Pin);
            if (user != null)
                return user;
            return null;            
        }
    }
}
