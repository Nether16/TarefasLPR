using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Aluno
    {
        public string Nome { get; }
        public int ID { get; }

        public List<Matricula> matriculas = new List<Matricula>();
    }
}
