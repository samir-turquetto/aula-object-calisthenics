using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Transacao
    {
        public Guid Id { get; private set; }
        public Pessoa Pessoa { get; private set; }
        private ListaDeProdutos Produtos { get; set; } = new ListaDeProdutos();

        public Transacao(Pessoa pessoa)
        {
            Id = Guid.NewGuid();
            Pessoa = pessoa;
        }

        public void AdicionarProduto(Produto produto)
            => Produtos.Add(produto);

        public decimal GetTotalTransacao()
            => Produtos.Sum(x => x.Valor);
    }
}
