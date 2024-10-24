using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImpostoDeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o Nome do Funcionario : ");
            string nome = Console.ReadLine();
            Console.Write($"Insira o Salario Bruto do {nome} : ");
            float salario = float.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario();

            funcionario.Nome = nome;
            funcionario.SalarioBruto = salario;

            funcionario.SalarioLiquido();

            Console.ReadLine();
        }
    }
}
