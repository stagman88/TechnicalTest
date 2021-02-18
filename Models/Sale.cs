using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2021.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public int UnitsSold { get; set; }

        public Product ProductSold { get; set; }

        public Client ClientSoldTo { get; set; }
    }
}
