using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_Authentication_WebApi.Models;

namespace JWT_Authentication_WebApi.Data
{
    public static class UserMockData
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "Shaun",
                Role = "Administrator",
                Email = "shaun@gmail.com",
                Password = "shaun123"
            },
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "Habib",
                Role = "Manager",
                Email = "habib@gmail.com",
                Password = "habib123"
            },
            new User
            {
                Id = Guid.NewGuid(),
                UserName = "Shayan",
                Role = "Seller",
                Email = "shayan@gmail.com",
                Password = "shayan123"
            },
        };
    }
}