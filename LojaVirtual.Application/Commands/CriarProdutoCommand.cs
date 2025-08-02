using MediatR;
using System;

namespace LojaVirtual.Application.Commands
{
    public class CriarProdutoCommand : IRequest<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public string Tamanho { get; set; }
        public string Genero { get; set; }
        public Guid CategoriaId { get; set; }

        public CriarProdutoCommand() { }

        public CriarProdutoCommand(string nome, string descricao, decimal preco, int estoque, string tamanho, string genero, Guid categoriaId)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Tamanho = tamanho;
            Genero = genero;
            CategoriaId = categoriaId;
        }
    }
}
