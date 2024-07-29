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
        public Beca() { }
        public Beca(string pCodigo, DateTime pFecha, decimal pImporte, Alumno pAlumno)
        {
            Codigo = pCodigo; Fecha_Otorgamiento = pFecha; Importe = pImporte; Alumno = pAlumno;
            pagado = false;
        }
        public string Codigo { get; set; }
        public DateTime Fecha_Otorgamiento { get; set; }
        decimal importe;
        public event EventHandler evento;
        public decimal Importe
        {
            get { return importe; }
            set
            {
                importe = value;
                if(Alumno != null) { if (value > Alumno.Cuota) evento?.Invoke(this, null); }
            }
        }
        public Alumno Alumno { get; set; }
        public bool pagado { get; set; }
        public decimal Neto { get; set; }
    }
}
