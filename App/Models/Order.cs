using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AccountId { get; set; }
        public string AnotherAddress { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
