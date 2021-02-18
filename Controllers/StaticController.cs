using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2021.Models;

namespace WebApplication2021.Controllers
{
    [ApiController]
    [Route("/api/static")]
    public class StaticController : ControllerBase
    {
        private static readonly string[] Clients = new[]
       {
            "Fantastic Flipflops",
            "Advanced Acrobatic Androids", 
            "Chunky Chewbacca Cookies", 
            "Legally Legal Services", 
            "Deviously Delicious Delicacies",
            "Green Garden Grandpas",
            "Perky Pet Pampering", 
            "La Loca Lunches"
        };

        private readonly ILogger<StaticController> _logger;

        public StaticController(ILogger<StaticController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("populatestaticdata")]
        public void PopulateStaticData()
        {

            using (var db = new WebAppDbContext()) {

                // Add a half dozen products.
                db.Products.Add(new Product()
                {
                    ProductName = "Product 1",
                    ProductCost = 1000,
                    ProductSalePrice = 1500
                });

                db.Products.Add(new Product()
                {
                    ProductName = "Product 2",
                    ProductCost = 1000,
                    ProductSalePrice = 1100
                });


                db.Products.Add(new Product()
                {
                    ProductName = "Product 3",
                    ProductCost = 1000,
                    ProductSalePrice = 1005
                });

                db.Products.Add(new Product()
                {
                    ProductName = "Product 4",
                    ProductCost = 5000,
                    ProductSalePrice = 5500
                });

                db.Products.Add(new Product()
                {
                    ProductName = "Product 5",
                    ProductCost = 100,
                    ProductSalePrice = 750
                });


                db.Products.Add(new Product()
                {
                    ProductName = "Product 6",
                    ProductCost = 100,
                    ProductSalePrice = 7500
                });

                

                // Add a number of clients.
                foreach (var clientName in Clients)
                {
                    Random r = new Random();
                    var newClient = new Client()
                    {
                        ClientName = clientName,
                        Sales = new List<Sale>()
                    };

                    // Add a random number of sales.
                    for (var i = 0; i <= r.Next(1, 100); i++)
                    {
                        var product = db.Products.Local.ToList()[r.Next(0, 5)];

                        newClient.Sales.Add(new Sale()
                        {
                            ProductSold = product,
                            ClientSoldTo = newClient,
                            UnitsSold = r.Next(0, 1000)
                        });
                    }
                    db.Clients.Add(newClient);
                }

                

                db.SaveChanges();
            }
        }
    }
}
