using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Premiacion
    {
        List<Pelicula> lPelicula;
        List<Director> lDirector;
        public Premiacion()
        {
            lPelicula = new List<Pelicula>();
            lDirector = new List<Director>();
        }
        public void AgregarPelicula(Pelicula p)
        {
            lPelicula.Add(p);
        }
        public void EliminarPelicula(Pelicula p)
        {
            lPelicula.Remove(p);
        }
        public List<Pelicula> getPeliculas()
        {
            return lPelicula;
        }
        public void AgregarDirector(Director d)
        {
            lDirector.Add(d);
        }
        public void EliminarDirector(Director d)
        {
            lDirector.Remove(d);
        }
        public List<Director> getDirectores()
        {
            return lDirector;
        }
    }
}
