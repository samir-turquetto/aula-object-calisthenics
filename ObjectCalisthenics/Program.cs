using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var pessoa = new Pessoa("89828707500", "PESSOA TESTE 1");
                var produto = new Produto("PRODUTO TESTE 1", 99.90m);
                var produto1 = new Produto("PRODUTO TESTE 2", 99.90m);
                var produto2 = new Produto("PRODUTO TESTE 3", 99.90m);
                var transacao = new Transacao(pessoa);

                transacao.AdicionarProduto(produto);
                transacao.AdicionarProduto(produto1);
                transacao.AdicionarProduto(produto2);

                transacao.ListarProdutos();
                
                Console.WriteLine($"Transação para o cliente: {transacao.GetNomePessoa()}");
                Console.WriteLine($"Valor Total Transação: {transacao.GetTotalTransacao()}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        //private static void ExecutarPrimeroFor()
        //{
        //    for (int i = 0; i < 10; i++)
        //        ExecutarSegundoFor(i);
        //}

        //private static void ExecutarSegundoFor(int i)
        //{
        //    for (int x = 0; x < 10; x++)
        //        Console.WriteLine(i + x);

        //    Console.WriteLine("\n");
        //}
    }
}
