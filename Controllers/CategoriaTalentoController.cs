using ESII2025d2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESII2025d2.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class CategoriaTalentoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CategoriaTalentoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoriaTalento>>> GetCategoriaTalento()
    {
        return await _context.CategoriasTalento.ToListAsync();
    }
    
}