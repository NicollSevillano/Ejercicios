using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Ejercicio5
{
    public class Beca
    {
        public Beca(string pCodigo, DateTime pFecha, decimal pImporte, Alumno pAlumno)
        {
            Codigo = pCodigo; Fecha_Otorgamiento = pFecha; Importe = pImporte; Alumno = pAlumno;
        }
        public string Codigo { get; set; }
        public DateTime Fecha_Otorgamiento { get; set; }
        public decimal Importe { get; set; }
        public Alumno Alumno { get; set; }
        int cantidad;
        public event EventHandler evento;
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                cantidad = value;
                if (Alumno != null) { if (value > Alumno.Cantidad_Beca && Alumno.Cantidad_Beca >= 2) evento?.Invoke(this, null); }
            }
        }
    }
}
