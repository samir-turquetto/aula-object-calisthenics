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
                var pessoa = new Pessoa("89828707500", "TESTE 1");
                Console.WriteLine(pessoa.GetDocumento());
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
