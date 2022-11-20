using Microsoft.EntityFrameworkCore;
using Ozbek.Bank.Core.DTOs;
using Ozbek.Bank.Core.Models.Entity;
using Ozbek.Bank.Core.Repositories;
using Ozbek.Bank.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Repository.Repositories
{
    public class UserAccountRepository : GenericRepository<UserAccount>, IUserAccountRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserAccountRepository(OzbekBankDbContext context, IUnitOfWork unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }

        public ServiceResponse Deposit(WithdrawDepositDto model)
        {
            if (model.Amount < 0)
                return ServiceResponse.Failed("Geçersiz tutar girdiniz.");

            var userAccount = _context.UserAccounts.FirstOrDefault(x => x.UserId == model.UserId & x.AccountTypeId == model.AccountType);
            if (userAccount == null)
                return ServiceResponse.Failed("Kullanıcı hesabı bulunamadı.");

            userAccount.Balance = userAccount.Balance + model.Amount;
            _unitOfWork.Commit();
            return ServiceResponse.Successful("Ok");
        }

        public ServiceResponse Withdraw(WithdrawDepositDto model)
        {
            if (model.Amount < 0)
                return ServiceResponse.Failed("Geçersiz tutar girdiniz.");

            var userAccount = _context.UserAccounts.FirstOrDefault(x => x.UserId == model.UserId & x.AccountTypeId == model.AccountType);
            if (userAccount == null)
                return ServiceResponse.Failed("Kullanıcı hesabı bulunamadı.");

            if (userAccount.Balance - model.Amount < 0)
                return ServiceResponse.Failed("Yetersiz Bakiye");


            userAccount.Balance = userAccount.Balance - model.Amount;
            _unitOfWork.Commit();
            return ServiceResponse.Successful("Ok");

        }
    }
}
