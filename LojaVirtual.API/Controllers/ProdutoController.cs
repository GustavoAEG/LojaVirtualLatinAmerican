using LojaVirtual.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarProduto([FromBody] CriarProdutoCommand command)
        {
            var produtoId = await _mediator.Send(command);
            return Ok(new { Id = produtoId, Mensagem = "Produto adicionado com sucesso!" });
        }
    }
}
