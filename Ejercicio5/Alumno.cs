using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public abstract class Alumno
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public List<Beca> Beca { get; set; }
        public int Cantidad_Beca { get; set; }
    }
    public class bIngresante : Alumno
    {
        public bIngresante(string pLegajo, string pNombre, string pApellido, string pDni)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; DNI = pDni;
            Beca = new List<Beca>();
        }
    }
    public class bGrado : Alumno
    {
        public bGrado(string pLegajo, string pNombre, string pApellido, string pDni)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; DNI = pDni;
            Beca = new List<Beca>();
        }
    }
    public class bPosgrado : Alumno
    {
        public bPosgrado(string pLegajo, string pNombre, string pApellido, string pDni)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; DNI = pDni;
            Beca = new List<Beca>();
        }
    }
}
