using Ozbek.Bank.Core.DTOs;
using Ozbek.Bank.Core.Models.Entity;


namespace Ozbek.Bank.Core.Repositories
{
    public interface IUserAccountRepository : IGenericRepository<UserAccount>
    {
         ServiceResponse Withdraw(WithdrawDepositDto model);
         ServiceResponse Deposit(WithdrawDepositDto model);
    }
}
