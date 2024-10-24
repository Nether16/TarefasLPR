using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosMatriculados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os Dados do Aluno : ");
            Console.Write("Matricula : "); int matricula = int.Parse(Console.ReadLine());
            Console.Write("Nome : "); string nome = Console.ReadLine();
            Console.Write("Primeira Prova: "); float prova1 = float.Parse(Console.ReadLine());
            Console.Write("Segunda Prova : "); float prova2 = float.Parse(Console.ReadLine());
            Console.Write("Trabalho : "); float trabalho = float.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(matricula, nome, prova1, prova2, trabalho);

            aluno.Media();

            var passou = aluno.Final();

            if (passou != 0)
            {
                Console.WriteLine($"Voce ficou de final e vai precisar de {passou} na prova final");
            }
            else
            {
                if (passou < 30)
                {
                    Console.WriteLine("Voce Reprovou");
                }
            }

            Console.ReadLine();
        }
    }
}
