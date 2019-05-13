using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using App.Models.ResModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("get-list")]
        public async Task<List<ProductItem>> GetList()
        {
            var list = await _context.Products
                .Select( p => new ProductItem {
                    Id = p.Id,
                    AvatarPath = p.ProductImages.FirstOrDefault().Path,
                    Description = p.Description,
                    Name = p.Name,
                    Price = p.Price,
                    PromotionPercent = p.PromotionPercent
                })
                .ToListAsync();
            list.Add(new ProductItem
            {
                Id = 1,
                Price = 500,
                PromotionPercent = 10,
                Name = "Tivi",
                Description = "No desc",
                AvatarPath = "aaa"
            });
            return list;
        }

        [AllowAnonymous]
        [HttpGet("get/{id}")]
        public async Task<Product> GetList(int id)
        {
            var product = await _context.Products
                .SingleOrDefaultAsync(p => p.Id == id);

            product = new Product
            {
                Id = 1,
                Price = 500,
                PromotionPercent = 10,
                Name = "Tivi",
                Description = "No desc",
            };

            return product;
        }
    }
}