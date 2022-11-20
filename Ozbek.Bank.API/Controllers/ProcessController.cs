using Home.Api.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ozbek.Bank.Core.DTOs;
using Ozbek.Bank.Core.Repositories;
using System.Security.Claims;

namespace Ozbek.Bank.API.Controllers
{


    [Authorize]
    [Route("process")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private readonly IUserAccountRepository _userAccountRepository;
        public ProcessController(IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
        }
        [HttpPost("withdraw")]
        public async Task<IActionResult> Withdraw([FromBody] WithdrawDepositDto model)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            model.UserId = Convert.ToInt32(identity.FindFirst("UserId").Value);

            return Ok(_userAccountRepository.Withdraw(model));


        }

        [HttpPost("deposit")]
        public async Task<IActionResult> Deposit([FromBody] WithdrawDepositDto model)
        {
            model.UserId = 1;
            return Ok(_userAccountRepository.Deposit(model));


        }
    }
}
