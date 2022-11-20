using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Core.Models.Entity
{
    public class UserAccount : BaseEntity
    {
        [Key]
        public int UserAccountId { get; set; }

        public int UserId { get; set; }

        public int AccountTypeId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Balance { get; set; }

        public User User { get; set; }

        public AccountType AccountType { get; set; }
    }
}
