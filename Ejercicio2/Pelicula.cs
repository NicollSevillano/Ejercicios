using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public abstract class Pelicula
    {
        public Pelicula() { }
        public int id { get; set; }
        public static int cont = 1;
        public string pNombre { get; set; }
        public Genero Genero { get; set; }
        public Director Director { get; set; }
        public bool Premiado { get; set; }
        DateTime _estreno;
        public event EventHandler Evento;
        public DateTime Estreno 
        {
            get { return _estreno; }
            set
            {
                _estreno = value;
                if (value.Year <= 1980) Evento?.Invoke(this, null);
            }
        }
    }
    public class PeliculaASC : IComparer<Pelicula>
    {
        public int Compare(Pelicula x, Pelicula y)
        {
            return string.Compare(x.pNombre, y.pNombre);
        }
    }
    public class PeliculaDESC : IComparer<Pelicula>
    {
        public int Compare(Pelicula x, Pelicula y)
        {
            return string.Compare(x.pNombre, y.pNombre) * -1;
        }
    }
    public enum Genero { Clasica, Estreno }
    public class pClasica : Pelicula
    {
        public pClasica(string cNombre, Genero cGenero, Director cDirector)
        {
            id = cont;
            cont++;
            pNombre = cNombre; Genero = cGenero; Director = cDirector;
            Premiado = false;
        }
    }
    public class pEstreno : Pelicula
    {
        public pEstreno(string eNombre, Genero eGenero, Director eDirector)
        {
            id = cont;
            cont++;
            pNombre = eNombre; Genero = eGenero; Director = eDirector;
            Estreno = DateTime.Now;
            Premiado = false;
        }
    }
}
