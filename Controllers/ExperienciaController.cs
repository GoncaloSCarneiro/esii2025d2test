using ESII2025d2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESII2025d2.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ExperienciaController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ExperienciaController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Experiencia>>> GetExperiencia()
    {
        return await _context.Experiencias.ToListAsync();
    }
    
}