using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private AppDbContext _context;
        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<Account> Login(string phone, string password)
        {
            var account = await _context.Accounts
                .SingleOrDefaultAsync(a => a.PhoneNumber == phone && a.Password == password);

            account = new Account
            {
                Id = 1,
                FirstName = "Dinh Quang",
                LastName = "Minh",
                PhoneNumber = "0822535397",
                Password = "123456",
                Address = "Thiên phước"
            };

            return account;
        }
    }
}