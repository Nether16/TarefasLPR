using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosMatriculados
{
    class Aluno
    {
        public int Matricula;
        public string Nome;
        public float Prova1;
        public float Prova2;
        public float Trabalho;

        public Aluno(int matricula,string nome,float prova1,float prova2,float trabalho)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Prova1 = prova1;
            this.Prova1 = prova2;
            this.Trabalho = trabalho;
        }
        public void Media()
        {
            float media = ((Prova1 * 2.5f) + (Prova2 * 2.5f) + (Trabalho * 2)) / 7;
            Console.WriteLine($"A sua media é de : {media}");
        }

        public float Final()
        {
            float media = ((Prova1 * 2.5f) + (Prova2 * 2.5f) + (Trabalho * 2)) / 7;

            if (media >= 30)
            {
                var notafinal = (media - 180) * -1 + 30;
                return notafinal;
            }
            else
            {
                return 0f;
            }
        }
    }
}
