using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkLookUpAPI.Models;

namespace ParkLookUpAPI.Controllers
{
    [Route("api/parklookup/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private readonly ParkLookUpAPIContext _db;
        public ParksController(ParkLookUpAPIContext db)
        {
            _db = db;
        }
        // GET /api/parklookup/parks?state=Wyoming&isopen=true
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Park>>> Get(string state, bool isOpen) //example query: ?age=27 or ?isEliminated=false
        {
            var query = _db.Parks.AsQueryable();
            if (state != null) //string age = "12"  int intAge = 12
            {
                query = query.Where(entry => entry.State == state);
            }
            if (isOpen == true || false)
            {
                query = query.Where(entry => entry.IsOpen == isOpen);
            }
            return await query.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Park>>> Post(Park park)
        {
            _db.Parks.Add(park);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetParkById), new { id = park.ParkId }, park);
        }

        //https://localhost:5001/api/parklookup/parks/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Park>> GetParkById(int id)
        {
            var Park = await _db.Parks.FindAsync(id);
            if (Park == null)
            {
                return NotFound();
            }
            return Park;
        }

        
        //DELETE: api/parklookup/parks/2
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePark(int id)
        {
          var park = await _db.Parks.FindAsync(id);
          if (park == null)
          {
            return NotFound();
          }
          _db.Parks.Remove(park);
          await _db.SaveChangesAsync();
          return NoContent();
        }

        //PUT: api/parklookup/parks/2
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Park park)
        {
          if (id != park.ParkId)
          {
            return BadRequest();
          }
          _db.Entry(park).State = EntityState.Modified;
          try
          {
            await _db.SaveChangesAsync();
          }
          catch (DbUpdateConcurrencyException)
          {
            if (!ParkExists(id))
            {
              return NotFound();
            }
            else
            {
              throw;
            }
          }
          return NoContent();
        }

        private bool ParkExists(int id)
        {
          return _db.Parks.Any(e => e.ParkId == id);
        }
    }
}