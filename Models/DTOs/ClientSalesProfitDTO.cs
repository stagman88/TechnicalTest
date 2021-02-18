using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2021.Models
{
    public class ClientSalesProfitDTO
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public decimal TotalSalesIncome { get; set; }
    }
}
