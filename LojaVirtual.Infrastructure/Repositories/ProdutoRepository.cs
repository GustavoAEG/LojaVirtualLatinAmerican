using LojaVirtual.Domain.Entities;
using LojaVirtual.Domain.Interfaces;
using LojaVirtual.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly LojaVirtualContext _context;

        public ProdutoRepository(LojaVirtualContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }
    }
}
