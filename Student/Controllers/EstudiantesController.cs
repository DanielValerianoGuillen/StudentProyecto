using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student.Models;

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly DemoContext _context;
        public EstudiantesController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetInvoices()
        {
            if (_context.estudiantes == null)
            {
                return NotFound();
            }
            return await _context.estudiantes.Include(x => x.matriculas).ToListAsync();
        }
    }
}
