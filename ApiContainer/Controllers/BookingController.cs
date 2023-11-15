using ApiContainer.Common;
using ApiContainer.Dto;
using ApiContainer.Models;
using ApiContainer.Services.Booking;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ApiContainer.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BookingController : Controller
    {
        private readonly IBookingService bookingService;
        private readonly IOptionsMonitor<AppSettings> appSettings;

        public BookingController(IBookingService bookingService, IOptionsMonitor<AppSettings> appSettings)
        {
            this.bookingService = bookingService;
            this.appSettings = appSettings;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var bookingList = bookingService.GetListBooking();
            return Ok(new ResponseApi<List<Booking>>(true, "Get all list booking successfully", bookingList));
        }

        [Authorize]
        [HttpGet("getByUserId")]
        public ActionResult GetByUserId()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var SecretKey = appSettings.CurrentValue.SecretKey;
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var token = HttpContext.Request.Headers["Authorization"];


            tokenHandler.ValidateToken(token.ToString().Split(" ")[1], new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateAudience = false,
                ValidateIssuer = false,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "Id").Value);

            var bookingList = bookingService.GetListBookingByUserId(userId);
            return Ok(new ResponseApi<List<Booking>>(true, "Get all list booking successfully", bookingList));
        }

        [Authorize]
        [HttpPost("create")]
        public ActionResult Add(AddBookingDto addBookingDto)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var SecretKey = appSettings.CurrentValue.SecretKey;
                var key = Encoding.ASCII.GetBytes(SecretKey);
                var token = HttpContext.Request.Headers["Authorization"];


                tokenHandler.ValidateToken(token.ToString().Split(" ")[1], new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "Id").Value);
                var result = bookingService.AddBooking(userId, addBookingDto);
                return Ok(new ResponseApi<Boolean>(result, "Create booking successfully", result));
            }
            catch (Exception)
            {

                return Unauthorized(new ResponseApi<Boolean>(false, "Forbidden", false));

            }
        }


    }
}
