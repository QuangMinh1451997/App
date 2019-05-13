using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models.ResModel
{
    public class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PromotionPercent { get; set; }
        public string Description { get; set; }
        public string AvatarPath { get; set; }
    }
}
