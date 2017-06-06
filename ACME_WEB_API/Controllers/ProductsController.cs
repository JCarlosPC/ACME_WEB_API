using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ACME_WEB_API.Models;

namespace ACME_WEB_API.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Integral Rice", Category = "Seeds", Price = 5.50M },
            new Product { Id = 2, Name = "SledgeHammer", Category = "Hardware", Price = 500 },
            new Product { Id = 3, Name = "Skate", Category = "Sports", Price = 100 }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
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
    }
}
