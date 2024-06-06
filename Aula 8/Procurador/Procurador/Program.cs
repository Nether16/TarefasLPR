using System;

namespace Procurador
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 1, 5, 3, 7, 5, 3, 1 },posicoes = new int[numeros.Length];
            int numero = 0,ocorrencia = 0;
            Console.WriteLine("Entre com um numero para ser procurado no Vetor");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    ocorrencia++;
                    posicoes[i] = i;
                }
            }
            Console.Write($"O numero {numero} aparece {ocorrencia} vezes nas posiçoes ");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (posicoes[i] != 0)
                {
                    Console.Write($"{i+1} ");
                }
                    
            }
            Console.ReadLine();
        }
    }
}
