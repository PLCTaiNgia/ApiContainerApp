using ApiContainer.Dto;
using ApiContainer.Models;
using ApiContainer.Repositories.UserRepository;
using DevOne.Security.Cryptography.BCrypt;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiContainer.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly AppSettings appSettings;

        public AuthService(IUserRepository userRepository, IOptionsMonitor<AppSettings> optionsMonitor)
        {
            this.userRepository = userRepository;
            this.appSettings = optionsMonitor.CurrentValue;
        }

        public bool ChangePassword(int id, ChangePasswordModel changePasswordModel)
        {
            var user = userRepository.FindById(id);
            if (user == null)
            {
                return false;
            }

            var isValidPassword = BCryptHelper.CheckPassword(changePasswordModel.OldPassword, user.Password);
            if (!isValidPassword)
            {
                return false;
            }

            var salt = BCryptHelper.GenerateSalt(10);
            var hashedPassword = BCryptHelper.HashPassword(changePasswordModel.NewPassword, salt);

            var updateUser = user;
            updateUser.Password = hashedPassword;

            var changePasswordSuccess = userRepository.UpdateUser(user.Id, updateUser);

            return changePasswordSuccess;
        }

        public ResponseAuth Login(LoginModel loginModel)
        {
            var user = userRepository.FindByUsername(loginModel.Username);

            if (user == null)
                return null;
            var isValidPassword = BCryptHelper.CheckPassword(loginModel.Password, user.Password);
            if (!isValidPassword)
            {
                return null;
            }

            var accessToken = GenerateToken(user);

            return new ResponseAuth(user, new Token { AccessToken = accessToken });

        }


        public bool Register(RegisterModel registerModel)
        {
            var user = userRepository.FindByUsername(registerModel.Username);
            var lastUser = userRepository.FindAll().Last();


            if (user != null)
                return false;

            var salt = BCryptHelper.GenerateSalt(10);
            var hashedPassword = BCryptHelper.HashPassword(registerModel.Password, salt);

            var success = userRepository.CreateUser(new User { Id = lastUser.Id + 1, FullName = registerModel.FullName, Password = hashedPassword, Username = registerModel.Username });

            if (!success)
                return false;

            return true;
        }


        private string GenerateToken(User user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var secretKeyBytes = Encoding.UTF8.GetBytes(appSettings.SecretKey);

            var tokenDesc = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity
                (
                    new[]
                    {
                        new Claim("Username", user.Username),
                        new Claim("FullName", user.FullName),
                        new Claim("Id", user.Id.ToString()),

                        new Claim("TokenId", Guid.NewGuid().ToString())
                    }
                ),

                Expires = DateTime.UtcNow.AddDays(365),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha512Signature),
            };


            var token = jwtTokenHandler.CreateToken(tokenDesc);

            return jwtTokenHandler.WriteToken(token);
        }

    }
}
