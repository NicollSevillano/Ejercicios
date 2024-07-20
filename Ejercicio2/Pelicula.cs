using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Pelicula
    {
        public Pelicula() { }
        public Pelicula(string pNombre, string pGenero, Director pDirector, DateTime pEstreno)
        {
            Nombre = pNombre; Genero = pGenero; Director = pDirector; Estreno = pEstreno;
        }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public Director Director { get; set; }
        public DateTime Estreno { get; set; }
    }
    public class PeliculaASC : IComparer<Pelicula>
    {
        public int Compare(Pelicula x, Pelicula y)
        {
            return string.Compare(x.Nombre, y.Nombre);
        }
    }
    public class PeliculaDESC : IComparer<Pelicula>
    {
        public int Compare(Pelicula x, Pelicula y)
        {
            return string.Compare(x.Nombre, y.Nombre) * -1;
        }
    }
}
