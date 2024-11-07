using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.AdicionarLivro("Harry Potter e a Pedra Filosofal", "J.K Rowling", 1997);
            biblioteca.ListarLivros();

            Console.ReadLine();
        }
    }
}
