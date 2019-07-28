using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefoniaAPI.Models;
using TelefoniaAPI.Models.Data;

namespace TelefoniaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanosController : ControllerBase
    {
        private readonly TelefoniaContext _context;

        public PlanosController(TelefoniaContext context)
        {
            _context = context;
        }

        // GET: api/Planos
        [HttpGet]
        public IEnumerable<Plano> GetPlanos()
        {
            return _context.Planos;
        }

        // GET: api/Planos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlano([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var plano = await _context.Planos.FindAsync(id);

            if (plano == null)
            {
                return NotFound();
            }

            return Ok(plano);
        }

        // PUT: api/Planos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlano([FromRoute] int id, [FromBody] Plano plano)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != plano.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(plano).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanoExists(id))
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

        // POST: api/Planos
        [HttpPost]
        public async Task<IActionResult> PostPlano([FromBody] Plano plano)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Planos.Add(plano);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlano", new { id = plano.Codigo }, plano);
        }

        // DELETE: api/Planos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlano([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var plano = await _context.Planos.FindAsync(id);
            if (plano == null)
            {
                return NotFound();
            }

            _context.Planos.Remove(plano);
            await _context.SaveChangesAsync();

            return Ok(plano);
        }

        private bool PlanoExists(int id)
        {
            return _context.Planos.Any(e => e.Codigo == id);
        }
    }
}