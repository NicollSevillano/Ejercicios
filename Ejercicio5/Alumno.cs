using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        int cantidad = 0;
        public event EventHandler evento;
        public int Cantidad_Beca
        {
            get { return cantidad; }
            set
            {
                cantidad = value;
                if (value > 2) evento?.Invoke(this, null);
            }
        }
        public decimal Cuota { get; set; }
        public abstract decimal Cobrar(string pid);
        public string Beneficio { get; set; }
    }
    public class bIngresante : Alumno
    {
        public bIngresante(string pLegajo, string pNombre, string pApellido, string pDni, decimal pCuota)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; DNI = pDni;
            Beca = new List<Beca>(); Cuota = pCuota; Beneficio = "10%";
        }

        public override decimal Cobrar(string pid)
        {
            Beca aux = Beca.Find(x => x.Codigo == pid);
            decimal pagar = (Cuota - aux.Importe) * 0.9M;
            aux.pagado = true;
            aux.Neto = pagar;
            return pagar;
        }
    }
    public class bGrado : Alumno
    {
        public bGrado(string pLegajo, string pNombre, string pApellido, string pDni, decimal pCuota)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; DNI = pDni;
            Beca = new List<Beca>(); Cuota = pCuota; Beneficio = "5%";
        }

        public override decimal Cobrar(string pid)
        {
            Beca aux = Beca.Find(x => x.Codigo == pid);
            decimal pagar = (Cuota - aux.Importe) * 0.5M;
            aux.pagado = true;
            aux.Neto = pagar;
            return pagar;
        }
    }
    public class bPosgrado : Alumno
    {
        public bPosgrado(string pLegajo, string pNombre, string pApellido, string pDni, decimal pCuota)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; DNI = pDni;
            Beca = new List<Beca>(); Cuota = pCuota; Beneficio = "1%";
        }

        public override decimal Cobrar(string pid)
        {
            Beca aux = Beca.Find(x => x.Codigo == pid);
            decimal pagar = (Cuota - aux.Importe) * 0.1M;
            aux.pagado = true;
            aux.Neto = pagar;
            return pagar;
        }
    }
}
