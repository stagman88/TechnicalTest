using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2021.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string ClientName { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
