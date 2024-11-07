using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Biblioteca
    {
        List<Livro> Livros = new List<Livro>();

        public void AdicionarLivro(string titulo, string autor, int ano)
        {
            Livros.Add(new Livro(titulo,autor,ano)); 
        }

        public void ListarLivros()
        {
            foreach(Livro livro in Livros)
            {
                Console.WriteLine($"Titulo : {livro.Titulo} | Autor : {livro.Autor} | Ano de Lançamento {livro.Ano}");
            }
        }
    }
}
