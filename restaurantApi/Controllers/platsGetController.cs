using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using restaurantApi.Data;
using restaurantApi.Models;

namespace restaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class platsGetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public platsGetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/platsGet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<plat>>> Getplat()
        {
          if (_context.plat == null)
          {
              return NotFound();
          }
            return await _context.plat.ToListAsync();
        }

        // GET: api/platsGet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<plat>> Getplat(int id)
        {
          if (_context.plat == null)
          {
              return NotFound();
          }
            var plat = await _context.plat.FindAsync(id);

            if (plat == null)
            {
                return NotFound();
            }

            return plat;
        }

       

        private bool platExists(int id)
        {
            return (_context.plat?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
