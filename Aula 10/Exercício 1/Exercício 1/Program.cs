using System;
using System.Collections.Generic;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o numero de pessoas a serem adicionadas :");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os nomes das pessoas :");
            List<string> names = new List<string>();
            for(int i = 0; i < size; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            names.Sort();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{names[i]}");
            }
            Console.ReadLine();
        }
    }
}
