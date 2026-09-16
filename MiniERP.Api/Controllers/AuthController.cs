using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MiniERP.Core.Models;

namespace MiniERP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            if(model.UserName == "admin" && model.Password == "12345")
            {
                return Ok(new
                { 
                    Message = "Login Successfully"
                });
            }
            return Unauthorized(new
            {
                Message = "Invalid username or password"
            });
        }
    }
}
