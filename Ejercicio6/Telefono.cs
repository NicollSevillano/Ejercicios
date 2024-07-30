using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class Telefono
    {
        public Telefono(string pCodigo, int pNumero, Alumno pAlumno)
        {
            CodigoPais = pCodigo; Numero = pNumero; Alumno = pAlumno;
        }
        public string CodigoPais { get; set; }
        public int Numero { get; set; }
        public Alumno Alumno { get; set; }
    }
}
