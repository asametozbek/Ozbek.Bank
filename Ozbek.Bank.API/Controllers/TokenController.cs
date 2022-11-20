using Home.Api.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ozbek.Bank.API.Models;
using Ozbek.Bank.Core.DTOs;
using Ozbek.Bank.Core.Repositories;

namespace Ozbek.Bank.API.Controllers
{
    [Route("")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IJwtAuth _jwtAuth;
        private readonly IUserRepository _userRepository;
        public TokenController(IJwtAuth jwtAuth, IUserRepository userRepository)
        {
            _jwtAuth = jwtAuth;
            _userRepository = userRepository;
        }
        [HttpPost("token")]
        public async Task<IActionResult> Authentication([FromBody] LoginDto loginDto)
        {

            var user = await _userRepository.CheckUser(loginDto);
            if (user == null)
                return Ok(new ServiceResponse { Message = "Kullanıcı bulunamadı.", Success = false });

            UserCredential userCredential = new UserCredential()
            {
                UserId = user.UserId.ToString(),
                UserName = user.FirstName + " " + user.LastName
            };

            var token = _jwtAuth.Authentication(userCredential);
            if (token == null)
                return Ok(new ServiceResponse { Message = "Bir hata meydana geldi.", Success = false });

            return Ok(new { token = token });
        }
    }
}
