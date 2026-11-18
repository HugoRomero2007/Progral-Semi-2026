using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

[Route("api/[controller]")]
[ApiController]
public class MateriasController : ControllerBase
{
    private readonly MyDbContext _context;

    public MateriasController(MyDbContext context)
    {
        _context = context;
    }

    // GET: api/Materias
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Materia>>> GetMateria()
    {
        return await _context.Materias.ToListAsync(); // Corregido a 'Materias'
    }


    [HttpGet("buscar")]
    public async Task<ActionResult<IEnumerable<Materia>>> buscarMateria([FromQuery] AlumnoBusquedaParametros parametros)
    {
        var consulta = _context.Materias.AsQueryable();
        if (!string.IsNullOrEmpty(parametros.buscar))
        {

            consulta = consulta.Where(materia => materia.nombre.Contains(parametros.buscar));

        }
        return await consulta.ToListAsync();
    }


    // GET: api/Materias/5
    [HttpGet("{idmateria}")]
    public async Task<ActionResult<Materia>> GetMateria(int idmateria)
    {
        var materia = await _context.Materias.FindAsync(idmateria); // Corregido a 'Materias'

        if (materia == null)
        {
            return NotFound();
        }

        return materia;
    }

    // PUT: api/Materias/5
    [HttpPut("{idmateria}")]
    public async Task<IActionResult> PutMateria(int? idmateria, Materia materia)
    {
        if (idmateria != materia.IdMateria) // Corregido a 'IdMateria'
        {
            return BadRequest();
        }

        _context.Entry(materia).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MateriaExists(idmateria))
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

    // POST: api/Materias
    [HttpPost]
    public async Task<ActionResult<Materia>> PostMateria(Materia materia)
    {
        _context.Materias.Add(materia); // Corregido a 'Materias'
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetMateria", new { idmateria = materia.IdMateria }, materia); // Corregido a 'IdMateria'
    }

    // DELETE: api/Materias/5
    [HttpDelete("{idmateria}")]
    public async Task<IActionResult> DeleteMateria(int? idmateria)
    {
        var materia = await _context.Materias.FindAsync(idmateria); // Corregido a 'Materias'
        if (materia == null)
        {
            return NotFound();
        }

        _context.Materias.Remove(materia); // Corregido a 'Materias'
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool MateriaExists(int? idmateria)
    {
        return _context.Materias.Any(e => e.IdMateria == idmateria); // Corregido a 'Materias' e 'IdMateria'
    }
}