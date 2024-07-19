using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Turno
    {
        public Turno() { }
        static int a = 1;
        public Turno(DateTime fecha, Cliente cliente)
        {
            Fecha = fecha;
            Cliente = cliente;
            id = a;
            a ++;
        }
        public int id { get; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public class TurnoASC : IComparer<Turno>
        {
            public int Compare(Turno x, Turno y)
            {
                return x.id - y.id;
            }
        }
        public class TurnoDESC : IComparer<Turno>
        {
            public int Compare(Turno x, Turno y)
            {
                return x.id - y.id * -1;
            }
        }
    }
}
