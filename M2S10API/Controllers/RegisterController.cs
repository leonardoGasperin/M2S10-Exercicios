using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using M2S10API.Context;
using M2S10API.Models;

namespace M2S10API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly M2S10Context _context;

        public RegisterController(M2S10Context context)
        {
            _context = context;
        }

        // GET: api/Register
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Register>>> GetRegisters()
        {
          if (_context.Registers == null)
          {
              return NotFound();
          }
            return await _context.Registers.ToListAsync();
        }

        // GET: api/Register/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Register>> GetRegister(int id)
        {
          if (_context.Registers == null)
          {
              return NotFound();
          }
            var register = await _context.Registers.FindAsync(id);

            if (register == null)
            {
                return NotFound();
            }

            return register;
        }

        // PUT: api/Register/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegister(int id, Register register)
        {
            if (id != register.Id)
            {
                return BadRequest();
            }

            _context.Entry(register).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterExists(id))
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

        // POST: api/Register
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Register>> PostRegister(Register register)
        {
          if (_context.Registers == null)
          {
              return Problem("Entity set 'M2S10Context.Registers'  is null.");
          }
            _context.Registers.Add(register);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegister", new { id = register.Id }, register);
        }

        // DELETE: api/Register/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegister(int id)
        {
            if (_context.Registers == null)
            {
                return NotFound();
            }
            var register = await _context.Registers.FindAsync(id);
            if (register == null)
            {
                return NotFound();
            }

            _context.Registers.Remove(register);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegisterExists(int id)
        {
            return (_context.Registers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
