using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using webApiProject.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace webApiProject.Controllers
{
    public class AmbitionController : ApiController
    {
        List<Ambition> ambitions = new List<Ambition>();

        public AmbitionController() { }

        public AmbitionController(List<Ambition> ambitions)
        {
            this.ambitions = ambitions;
        }

        public IEnumerable<Ambition> GetAllProducts()
        {
            return ambitions;
        }

        public async Task<IEnumerable<Ambition>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }
    }
}
