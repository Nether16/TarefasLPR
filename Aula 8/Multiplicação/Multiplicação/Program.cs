using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Mult = { { 0, 0, 0 },{ 0, 0, 0 },{ 0, 0, 0 } };
            int[,] matrizA = { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
            int[,] matrizB = { { 7, 8, 9 },{ 4, 5, 6 },{ 1, 2, 3 } };

            Mult[0, 0] = (matrizA[0, 0] * matrizB[0, 0]) + (matrizA[0, 1] * matrizB[1, 0]) + (matrizA[0, 2] * matrizB[2, 0]);
            Mult[1, 0] = (matrizA[0, 0] * matrizB[0, 1]) + (matrizA[0, 1] * matrizB[1, 1]) + (matrizA[0, 2] * matrizB[2, 1]);
            Mult[2, 0] = (matrizA[0, 0] * matrizB[0, 2]) + (matrizA[0, 1] * matrizB[1, 2]) + (matrizA[0, 2] * matrizB[2, 2]);

            Mult[0, 1] = (matrizA[1, 0] * matrizB[0, 0]) + (matrizA[1, 1] * matrizB[1, 0]) + (matrizA[1, 2] * matrizB[2, 0]);
            Mult[1, 1] = (matrizA[1, 0] * matrizB[0, 1]) + (matrizA[1, 1] * matrizB[1, 1]) + (matrizA[1, 2] * matrizB[2, 1]);
            Mult[2, 1] = (matrizA[1, 0] * matrizB[0, 2]) + (matrizA[1, 1] * matrizB[1, 2]) + (matrizA[1, 2] * matrizB[2, 2]);

            Mult[0, 2] = (matrizA[2, 0] * matrizB[0, 0]) + (matrizA[2, 1] * matrizB[1, 0]) + (matrizA[2, 2] * matrizB[2, 0]);
            Mult[1, 2] = (matrizA[2, 0] * matrizB[0, 1]) + (matrizA[2, 1] * matrizB[1, 1]) + (matrizA[2, 2] * matrizB[2, 1]);
            Mult[2, 2] = (matrizA[2, 0] * matrizB[0, 2]) + (matrizA[2, 1] * matrizB[1, 2]) + (matrizA[2, 2] * matrizB[2, 2]);

            Console.WriteLine($"{Mult[0, 0]} {Mult[1, 0]} {Mult[2, 0]}\n{Mult[0, 1]} {Mult[1, 1]} {Mult[2, 1]}\n{Mult[0, 2]} {Mult[1, 2]} {Mult[2, 2]}");
            Console.Read();
        }
    }
}
