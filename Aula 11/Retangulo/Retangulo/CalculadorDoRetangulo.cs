using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class CalculadorDoRetangulo
    {
        public double Altura;
        public double Largura;
        private double resultado;

        public void CalcPerimetro()
        {
            resultado = (Altura * 2) + (Largura * 2);
            Console.WriteLine($"O perimetro do retangulo é - {resultado}");
        }

        public void CalcArea()
        {
            resultado = Largura * Altura;
            Console.WriteLine($"A area do retangulo é - {resultado}");
        }

    }
}
