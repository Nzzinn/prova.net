using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIExemplo.Data;
using APIExemplo.Models;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Diagnostics;

namespace APIExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentosController : ControllerBase
    {
        private readonly ExemploContext _context;

        public MedicamentosController(ExemploContext context)
        {
            _context = context;
        }

        // GET: api/Medicamentoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicamento>>> GetMedicamentos()
        {
            if (_context.Medicamentos == null)
            {
                return NotFound();
            }
            return await _context.Medicamentos.ToListAsync();
        }

        // GET: api/Medicamentoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicamento>> GetMedicamento(int id)
        {
            if (_context.Medicamentos == null)
            {
                return NotFound();
            }
            var medicamento = await _context.Medicamentos.FindAsync(id);

            if (medicamento == null)
            {
                return NotFound();
            }

            return medicamento;
        }

        // POST: api/Medicamentoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Medicamento>> PostMedicamento(Medicamento medicamento)
        {
            if (_context.Medicamentos == null)
            {
                return Problem("Entity set 'ExemploContext.Medicamentos'  is null.");
            }

            _context.Medicamentos.Add(medicamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicamento", new { id = medicamento.Id }, medicamento);
        }

    }
}
