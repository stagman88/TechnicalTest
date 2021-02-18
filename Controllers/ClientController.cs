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
    [Route("/api/clients")]
    public class ClientController : ControllerBase
    {

        [HttpGet]
        [Route("totalclientscount")]
        public int GetTotalClients()
        {

            using (var db = new WebAppDbContext())
            {
                return db.Clients.Count();
            }
        }


        [HttpGet]
        [Route("allclients")]
        public List<Client> GetAllClients()
        {

            using (var db = new WebAppDbContext())
            {
                return db.Clients.ToList();
            }
        }
    }
}
