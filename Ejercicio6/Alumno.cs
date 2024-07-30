using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public abstract class Alumno
    {
        public string Id { get; set; }
        public string Documento { get; set; }
        public string Numero_Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Telefono> TelefonoList { get; set; }
        int cantidad = 0;
        public event EventHandler evento;
        public int Cantidad_Telefono
        {
            get { return cantidad; }
            set
            {
                cantidad = value;
                if (value > 2) evento?.Invoke(this, null);
            }
        }
    }
    public class AlumnoAsc : IComparer<Alumno>
    {
        public int Compare(Alumno x, Alumno y)
        {
            return string.Compare(x.Nombre, y.Nombre);
        }
    }
    public class AlumnoDesc : IComparer<Alumno>
    {
        public int Compare(Alumno x, Alumno y)
        {
            return string.Compare(x.Nombre, y.Nombre) * -1;
        }
    }
    public class Extranjero : Alumno
    {
        public Extranjero(string pId, string pDocumento, string pNumero, string pNombre, string pApellido, string pUniversidad, int pCantidad)
        {
            Id = pId;
            Documento = pDocumento; Numero_Documento = pNumero;
            Nombre = pNombre; Apellido = pApellido;
            Universidad = pUniversidad; Cant_Materias = pCantidad;
            TelefonoList = new List<Telefono>();
        }
        public string Universidad { get; set; }
        public int Cant_Materias { get; set; }
    }
    public class Nacional : Alumno
    {
        public Nacional(string pId, string pDocumento, string pNumero, string pNombre, string pApellido)
        {
            Id = pId;
            Documento = pDocumento; Numero_Documento= pNumero;
            Nombre= pNombre; Apellido= pApellido;
            TelefonoList = new List<Telefono>();
        }
    }
}
