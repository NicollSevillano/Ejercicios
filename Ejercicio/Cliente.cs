using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string pDni, string pNombre, string pApellido)
        {
            DNI = pDni; Nombre = pNombre; Apellido = pApellido;
        }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
