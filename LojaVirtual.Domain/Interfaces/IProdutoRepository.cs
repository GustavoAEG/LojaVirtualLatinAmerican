using LojaVirtual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaVirtual.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Guid> AdicionarAsync(Produto produto);
        Task<Produto?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Produto>> ObterTodosAsync();
        Task AtualizarAsync(Produto produto);
        Task RemoverAsync(Guid id);
    }
}
