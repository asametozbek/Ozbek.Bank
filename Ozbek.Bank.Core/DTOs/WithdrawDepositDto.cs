using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Core.DTOs
{
    public class WithdrawDepositDto
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public int AccountType { get; set; } 
    }
}
