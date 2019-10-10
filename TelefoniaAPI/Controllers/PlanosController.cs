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
    public class PlanosController : ControllerBase
    {
        private readonly TelefoniaContext _context;

        public PlanosController(TelefoniaContext context)
        {
            _context = context;
        }

        // GET: api/Planos
        [HttpGet]
        public async Task<IActionResult> GetPlanos()
        {            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var plano = await _context.Planos
                .Select(p => new
                {
                    p.Codigo,
                    p.Minutos,
                    p.Franquia,
                    p.Valor,
                    p.Tipo,
                    p.Operadora,
                    DDDs = p.DDDs.Select(d => new
                    {
                        d.CodigoDDD
                    })
                }).ToListAsync();

            if (plano == null)
            {
                return NotFound();
            }

            return Ok(plano);
        }

        // GET: api/Planos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlano([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var plano = await _context.Planos
                .Where(p => p.Codigo == id)
                .Select(p => new
                {
                    p.Codigo,
                    p.Minutos,
                    p.Franquia,
                    p.Valor,
                    p.Tipo,
                    p.Operadora,
                    DDDs = p.DDDs.Select(d => new
                    {
                        d.CodigoDDD
                    })
                })
                .ToListAsync();

            if (plano == null)
            {
                return NotFound();
            }

            return Ok(plano);
        }

        // GET: api/Planos/tipo/tipoDoPlano
        [Route("[action]/{tipo}")]
        [HttpGet]
        public async Task<IActionResult> Tipo(string tipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var plano = await _context.Planos
                .Where(p => p.Tipo.ToString().ToUpper() == tipo.ToUpper())
                .Select(p => new
                {
                    p.Codigo,
                    p.Minutos,
                    p.Franquia,
                    p.Valor,
                    p.Tipo,
                    p.Operadora,
                    DDDs = p.DDDs.Select(d => new
                    {
                        d.CodigoDDD
                    })
                }).ToListAsync();

            if (plano == null)
            {
                return NotFound();
            }

            return Ok(plano);
        }

        // GET: api/Planos/operadora/nomeDaOperadora
        [Route("[action]/{operadora}")]
        [HttpGet]
        public async Task<IActionResult> Operadora(string operadora)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var plano = await _context.Planos.Where(p => p.Operadora.ToUpper() == operadora.ToUpper()).ToListAsync();

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

            if (!await OperadoraIsValidAsync(plano))
            {
                return BadRequest("Operadora não existente");
            }

            if (!await TipoIsValidAsync(plano))
            {
                return BadRequest("Tipo não existente");
            }

            _context.Entry(plano).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PlanoExistsAsync(id))
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

            if (!await OperadoraIsValidAsync(plano))
            {
                return BadRequest("Operadora não existente");
            }

            if (!await TipoIsValidAsync(plano))
            {
                return BadRequest("Tipo não existente");
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

        private async Task<bool> PlanoExistsAsync(int id)
        {
            return await _context.Planos.AnyAsync(e => e.Codigo == id);
        }

        private async Task<bool> TipoIsValidAsync(Plano plano)
        {
            return await _context.Planos.AnyAsync(p => p.Tipo == plano.Tipo);            
        }

        private async Task<bool> OperadoraIsValidAsync(Plano plano)
        {
            return await _context.Operadoras.AnyAsync(p => p.Descricao == plano.Operadora);           
        }
    }
}