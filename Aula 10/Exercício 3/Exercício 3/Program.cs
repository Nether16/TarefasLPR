using System;
using System.Collections.Generic;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Ages = new Dictionary<string, int>();

            int media = 0,old = 0,young = 0;
            string O = "", Y = "";
            Console.WriteLine("Insira a quantidade de pessoas a serem adicionadas :");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Insira o nome da pessoa :");
                string name = Console.ReadLine();
                Console.WriteLine("Insira a idade da pessoa :");
                int age = int.Parse(Console.ReadLine());

                Ages.Add(name, age);
                media += age;
            }

            media = media / quant;

            foreach (var p in Ages)
            {
                if ((p.Value < young)||(young == 0))
                {
                    young = p.Value;
                    Y = p.Key;
                }
                if (p.Value > old)
                {
                    old = p.Value;
                    O = p.Key;
                }
            }

            Console.WriteLine($"Pessoa com a idade acima da media ({media})");
            foreach (var p in Ages)
            {
                if (p.Value > media) Console.WriteLine($"Pessoa: {p.Key}, Idade: {p.Value}");
            }

            Console.WriteLine($"\nPessoa mais nova é {Y} com {young} anos");
            Console.WriteLine($"Pessoa mais velha é {O} com {old} anos");

            Console.WriteLine("Insira uma idade para ser removida :");
            int remove = int.Parse(Console.ReadLine());

            Console.WriteLine("Dicionario atualizado :");
            foreach (var p in Ages)
            {
                if (p.Value != remove) Console.WriteLine($"Pessoa: {p.Key}, Idade: {p.Value}");
            }

            Console.ReadLine();
        }
    }
}
