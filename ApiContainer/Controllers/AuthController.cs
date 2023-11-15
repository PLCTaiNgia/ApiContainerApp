using ApiContainer.Common;
using ApiContainer.Dto;
using ApiContainer.Models;
using ApiContainer.Services.AuthService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiContainer.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return Ok(new ResponseApi<string>(false, "Values is valid", null));
            }

            var result = authService.Login(loginModel);

            if (result == null)
            {
                return Ok(new ResponseApi<string>(false, "Wrong password or username", null));
            }

            return Ok(new ResponseApi<ResponseAuth>(true, "Login success", result));
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ResponseApi<string>(false, "Values is valid", null));

            var isRegisterSuccess = authService.Register(registerModel);
            if (!isRegisterSuccess)
                return Ok(new ResponseApi<string>(false, "Register failed", null));

            return Ok(new ResponseApi<bool>(true, "Register successfully", isRegisterSuccess));
        }

        [Authorize]
        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordModel changePasswordModel)
        {

            var userId = string.Empty;
            if (HttpContext.User.Identity is ClaimsIdentity identity)
            {
                userId = identity.FindFirst("Id")?.Value;
            }

            if (!ModelState.IsValid)
                return BadRequest(new ResponseApi<string>(false, "Values is valid", null));

            var isChangeSuccess = authService.ChangePassword(int.Parse(userId!), changePasswordModel);
            return Ok(new ResponseApi<bool>(true, "Change password successfully", isChangeSuccess));
        }
    }
}
