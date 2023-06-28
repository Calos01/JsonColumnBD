using JsonColumnBD.Context;
using JsonColumnBD.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JsonColumnBD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly DbContextSales _context;

        public SalesController(DbContextSales context)
        {
            _context = context;
        }
        // GET: api/<SalesController>
        [HttpPost]
        public IActionResult PostSales(Sales sales)
        {
            
            var dat=_context.sales.Add(sales); 
            _context.SaveChanges();

            if (dat != null)
            {
            return Ok("Insertado");
            }
            else
            {
                return Ok("Malo");
            }
        }
    }
}
