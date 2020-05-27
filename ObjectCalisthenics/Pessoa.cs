using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    internal class Pessoa
    {
        private Documento Documento { get; set; }
        public string Nome { get; private set; }

        public Pessoa(string documento, string nome)
        {
            Documento = new Documento(documento);
            Nome = nome;
        }

        public string GetDocumento()
            => Documento.ValorDocumento;
    }
}
