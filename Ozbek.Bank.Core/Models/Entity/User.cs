using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Core.Models.Entity
{
    public class User: BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(20)]
        public string IdentityNumber { get; set; }
        
        [StringLength(20)]
        public string  Pin { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }
        
        [StringLength(30)]
        public string LastName { get; set; }
        public ICollection<UserAccount> UserAccounts { get; set; }
    }
}
