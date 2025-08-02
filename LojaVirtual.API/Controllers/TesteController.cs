using LojaVirtual.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TesteController : ControllerBase
{
    private readonly LojaVirtualContext _context;

    public TesteController(LojaVirtualContext context)
    {
        _context = context;
    }

    [HttpGet("produtos")]
    public IActionResult GetProdutos()
    {
        var produtos = _context.Produtos.ToList();
        return Ok(produtos);
    }

    [HttpGet("categorias")]
    public IActionResult GetCategorias()
    {
        var categorias = _context.Categorias.ToList();
        return Ok(categorias);
    }
}
