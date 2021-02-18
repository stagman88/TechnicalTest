using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2021.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal ProductSalePrice { get; set; }

        public decimal ProductCost { get; set; }

        public List<Sale> SalesOfProduct { get; set; }
    }
}
