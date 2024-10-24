using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insira a Largura do Retangulo");
                double largura = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a Altura do Retangulo");
                double altura = double.Parse(Console.ReadLine());

                CalculadorDoRetangulo calculo = new CalculadorDoRetangulo();

                calculo.Largura = largura;
                calculo.Altura = altura;

                Console.WriteLine("Resultados");

                calculo.CalcArea();
                calculo.CalcPerimetro();

                Console.ReadLine();
            }
        }
    }
}
