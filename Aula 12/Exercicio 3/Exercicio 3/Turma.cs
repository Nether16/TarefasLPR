using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Turma
    {
        public int ID { get; }
        List<Aluno> alunos = new List<Aluno>();

        public void AddAluno(Aluno aluno)
        {
           foreach(Matricula turma in aluno.matriculas)
           {
                if (turma.IDTurma == this.ID) { alunos.Add(aluno); }
           }
        }

        public void MostrarAlunos(List<Aluno> alunos)
        {
            foreach(Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno : {aluno.Nome} - ID : {aluno.ID}");
            }
        }
    }
}
