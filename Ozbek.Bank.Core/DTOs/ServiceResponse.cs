using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozbek.Bank.Core.DTOs
{
    public class ServiceResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public static ServiceResponse Successful(string message)
        {
            return new ServiceResponse { Success = true, Message = message };
        }
        public static ServiceResponse Failed(string errorDescription)
        {
            return new ServiceResponse { Success = false, Message = errorDescription };
        }
    }
}
