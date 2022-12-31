using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Authentication_WebApi.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}