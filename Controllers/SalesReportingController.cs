using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2021.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2021.Controllers
{
    [ApiController]
    [Route("/api/salesreporting")]
    public class SalesReportingController : ControllerBase
    {
        [HttpGet]
        [Route("totalsales")]
        public decimal GetTotalSales()
        {

            using (var db = new WebAppDbContext())
            {
                return db.Sales.Sum(s => s.UnitsSold * s.ProductSold.ProductSalePrice);
            }
        }

        [HttpGet]
        [Route("totalsalesbyproduct")]
        public decimal GetTotalSalesByProduct(int productId)
        {

            using (var db = new WebAppDbContext())
            {
                return db.Sales.Where(s => s.ProductSold.Id == productId).Sum(s => s.UnitsSold * s.ProductSold.ProductSalePrice);
            }
        }



        [HttpGet]
        [Route("totalsalesbyclient")]
        public decimal GetTotalSalesByClient(int clientId)
        {

            using (var db = new WebAppDbContext())
            {
                return db.Sales.Where(s => s.ClientSoldTo.Id == clientId).Sum(s => s.UnitsSold * s.ProductSold.ProductSalePrice);
            }
        }

        [HttpGet]
        [Route("clientsalesprofit")]
        public List<ClientSalesProfitDTO> GetClientSalesProfit()
        {

            using (var db = new WebAppDbContext())
            {
                return db.Clients.Include(c => c.Sales).ThenInclude(s => s.ProductSold).Select(c => new ClientSalesProfitDTO()
                {
                    ClientId = c.Id,
                    ClientName = c.ClientName,
                    TotalSalesIncome = c.Sales.Sum(s => s.UnitsSold * s.ProductSold.ProductSalePrice),
                }).ToList();
                    
            }
        }
    }
}
