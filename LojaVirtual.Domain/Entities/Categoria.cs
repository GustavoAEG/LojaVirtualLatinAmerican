using System;
using System.Collections.Generic;

namespace LojaVirtual.Domain.Entities
{
    public class Categoria
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        // Relacionamento - uma categoria pode ter vários produtos
        public ICollection<Produto> Produtos { get; private set; }

        protected Categoria()
        {
            Produtos = new List<Produto>();
        }

        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Produtos = new List<Produto>();
        }
    }
}
