using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImpostoDeFuncionario
{
    class Funcionario
    {
        public string Nome;
        public float SalarioBruto;
        public float Imposto;

        public void SalarioLiquido()
        {
            if (SalarioBruto < 2000f) Imposto = 0.10f * SalarioBruto;
            if (SalarioBruto < 3000f) Imposto = 0.15f * SalarioBruto;
            if (SalarioBruto > 2000f) Imposto = 0.20f * SalarioBruto;

            Console.WriteLine($"Nome : {Nome} \nSalario Liquido = {SalarioBruto - Imposto}");
        }
    }
}
