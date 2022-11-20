using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Core.DTOs
{
    public class LoginDto
    {
        public string IdentityNumber { get; set; }
        public string Pin { get; set; }
    }
}
