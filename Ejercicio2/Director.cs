using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Director
    {
        public Director() { }
        public Director(string pInvitacion, string pNombre, string pApellido, DateTime pInicio)
        {
            codInvitacion = pInvitacion; Nombre = pNombre; Apellido = pApellido; Inicio = pInicio;
        }
        public string codInvitacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Inicio { get; set; }
    }
    public class DirectorASC : IComparer<Director>
    {
        public int Compare(Director x, Director y)
        {
            return string.Compare(x.Nombre, y.Nombre);
        }
    }
    public class DirectorDESC : IComparer<Director>
    {
        public int Compare(Director x, Director y)
        {
            return string.Compare(x.Nombre, y.Nombre) * -1;
        }
    }
}
