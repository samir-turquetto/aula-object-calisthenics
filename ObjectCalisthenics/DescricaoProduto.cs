using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class DescricaoProduto
    {
        public string Valor { get; private set; }

        public DescricaoProduto(string descricao)
        {
            SetDescricaoProduto(descricao);
        }

        private void SetDescricaoProduto(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("Descrição para o produto não poder ser nula ou vazia!");

            Valor = descricao;            
        }
    }
}
