using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using JWT_Authentication_WebApi.Data;
using JWT_Authentication_WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Authentication_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = UserMockData.Users.ToList();
            return Ok(users);
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            var user = GetCurrent();
            return Ok($"Hi {user.UserName}, your role is {user.Role}");
        }

        private User GetCurrent()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var identity2 = HttpContext.User.Identity;
            if (identity != null)
            {
                var claims = identity.Claims;
                return new User
                {
                    UserName = claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
                    Email = claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value,
                    Role = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }
    }
}