using Ozbek.Bank.Core.DTOs;
using Ozbek.Bank.Core.Models.Entity;


namespace Ozbek.Bank.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User> CheckUser(LoginDto model);
    }
}
