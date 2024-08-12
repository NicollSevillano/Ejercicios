using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Cliente
    {
        public Cliente()
        {
            id = cont;
            cont++;
        }
        public int id { get; set; }
        static int cont = 1;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
    }
}
