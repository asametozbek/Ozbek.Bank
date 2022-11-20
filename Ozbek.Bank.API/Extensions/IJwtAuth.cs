using Ozbek.Bank.API.Models;
using Ozbek.Bank.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Api.Extensions
{
    public interface IJwtAuth
    {
        string Authentication(UserCredential loginDto); 
    }
}
