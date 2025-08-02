using MediatR;
using System;
using System.Text.Json.Serialization;

namespace LojaVirtual.Application.Commands
{
    public class CriarProdutoCommand : IRequest<Guid>
    {
        public string Nome { get; }
        public string Descricao { get; }
        public decimal Preco { get; }
        public int Estoque { get; }
        public string Tamanho { get; }
        public string Genero { get; }
        public Guid CategoriaId { get; }

        [JsonConstructor] 
        public CriarProdutoCommand(
            string nome,
            string descricao,
            decimal preco,
            int estoque,
            string tamanho,
            string genero,
            Guid categoriaId)
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
