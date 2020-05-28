using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Produto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public Produto(string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
        }
    }
}
