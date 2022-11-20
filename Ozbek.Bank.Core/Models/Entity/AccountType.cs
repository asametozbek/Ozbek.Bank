using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Core.Models.Entity
{
    public class AccountType : BaseEntity
    {
        [Key]
        public int AccounTypeId { get; set; }       
        
        [StringLength(30)]
        public string Name { get; set; }
        public ICollection<UserAccount> UserAccounts { get; set; }
    }
}
