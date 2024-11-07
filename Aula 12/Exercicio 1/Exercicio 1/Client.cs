using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Client
    {
        public int ID;
        List<Reserva> reservas;

        public void VerReservas()
        {
            foreach(Reserva reserva in reservas)
            {
                Console.WriteLine(reserva.data);
                Console.WriteLine(reserva.hora);
            }
        }
    }
}
