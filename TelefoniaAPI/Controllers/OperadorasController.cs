using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelefoniaAPI.Models;
using TelefoniaAPI.Models.Data;

namespace TelefoniaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperadorasController : ControllerBase
    {
        private readonly TelefoniaContext _context;

        public OperadorasController(TelefoniaContext context)
        {
            _context = context;
        }

        // GET: api/Operadoras
        [HttpGet]
        public IEnumerable<Operadora> GetOperadoras()
        {
            return _context.Operadoras;
        }

        // GET: api/Operadoras/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOperadora([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var operadora = await _context.Operadoras.FindAsync(id);

            if (operadora == null)
            {
                return NotFound();
            }

            return Ok(operadora);
        }

        // PUT: api/Operadoras/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperadora([FromRoute] int id, [FromBody] Operadora operadora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != operadora.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(operadora).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperadoraExists(id))
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

        // POST: api/Operadoras
        [HttpPost]
        public async Task<IActionResult> PostOperadora([FromBody] Operadora operadora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Operadoras.Add(operadora);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOperadora", new { id = operadora.Codigo }, operadora);
        }

        // DELETE: api/Operadoras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOperadora([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var operadora = await _context.Operadoras.FindAsync(id);
            if (operadora == null)
            {
                return NotFound();
            }

            _context.Operadoras.Remove(operadora);
            await _context.SaveChangesAsync();

            return Ok(operadora);
        }

        private bool OperadoraExists(int id)
        {
            return _context.Operadoras.Any(e => e.Codigo == id);
        }
    }
}