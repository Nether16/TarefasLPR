using System;
namespace Separador
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0,y = 0;
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine($"Entre com o {i+1}º numero");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i]%2 == 0)
                {
                    pares[x] = numeros[i];
                    x++;
                }
                else
                {
                    impares[y] = numeros[i];
                    y++;
                }
            }

            Console.Write("Pares : ");
            for(int i = 0;i < pares.Length; i++)
            {
                if (pares[i] != 0)
                {
                    Console.Write($"{pares[i]},");
                }
            }
            Console.Write("\nImpares : ");
            for (int i = 0; i < impares.Length; i++)
            {
                if (impares[i] != 0)
                {
                    Console.Write($"{impares[i]},");
                }
            }
            Console.ReadLine();
        }
    }
}
