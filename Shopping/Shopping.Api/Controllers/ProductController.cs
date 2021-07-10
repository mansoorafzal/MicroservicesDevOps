using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.Api.Data;
using Shopping.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {   
            return await _context.Products.Find(p => true).ToListAsync();
        }
    }
}
