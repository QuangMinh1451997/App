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
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private AppDbContext _context;
        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("order")]
        public async Task<bool> Order(int[] productIds)
        {
            return true;
        }

        [AllowAnonymous]
        [HttpPost("get-list")]
        public async Task<List<Order>> GetList()
        {
            var list = await _context.Orders
                .ToListAsync();
            return list;
        }

        [AllowAnonymous]
        [HttpPost("get")]
        public async Task<Order> Get()
        {
            var order = await _context.Orders
                .SingleOrDefaultAsync();
            return order;
        }
    }
}