using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using webApiProject.Models;

namespace webApiProject.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>();

        public ProductsController() { }

        public ProductsController(List<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public async Task<IHttpActionResult> GetProductAsync(int id)
        {
            return await Task.FromResult(GetProduct(id));
        }

        //Product[] products = new Product[] {

        //    new Product {Id = 1,Name = "a",Category = "i", Price = 1 },
        //    new Product {Id = 2,Name = "b",Category = "ii", Price = 2},
        //    new Product {Id = 3,Name = "c",Category = "iii", Price = 3},
        //    new Product {Id = 4,Name = "d",Category = "iiii", Price = 4}
        //};
        //// GET api/<controller>
        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return products;
        //}

        //public IHttpActionResult GetProduct(int id) {
        //    var product = products.FirstOrDefault((p) => p.Id == id);

        //    if (product == null) {
        //        return NotFound();
        //    }
        //    return Ok(product + "hello" );
        //}

        //// POST api/<controller>
        //public void Post()
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}