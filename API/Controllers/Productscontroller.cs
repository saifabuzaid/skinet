using infrastructure.Data;
using core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Productscontroller : ControllerBase
    {
        private readonly StoreContext _context;
        public Productscontroller(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var r= await _context.products.ToListAsync();

            return Ok(r);
        }
        [HttpGet("{id}")]

          public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.products.FindAsync(id);
        }
    }
}