using Microsoft.AspNetCore.Mvc;
using apinet.Models;
using System.Collections.Generic;
using System.Linq;

namespace apinet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {s
        private static readonly List<Product> Products = new()
        {
            new Product { Id= 1, Name = "Laptop", Price = 999.99M},
            new Product { Id= 2, Name = "Laptop", Price = 999.99M}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => Ok(Products);
    }
}