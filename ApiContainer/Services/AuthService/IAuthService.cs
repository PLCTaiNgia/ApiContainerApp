using ApiContainer.Dto;
using ApiContainer.Models;

namespace ApiContainer.Services.AuthService
{
    public interface IAuthService
    {
        bool Register(RegisterModel registerModel);
        ResponseAuth Login(LoginModel loginModel);
        bool ChangePassword(int id, ChangePasswordModel changePasswordModel);
    }

    public class ResponseAuth
    {
        public User User { get; set; }
        public Token Token { get; set; }

        public ResponseAuth(User user, Token token)
        {
            User = user;
            Token = token;
        }
    }

    public class Token
    {
        public string AccessToken { get; set; }
    }
}
