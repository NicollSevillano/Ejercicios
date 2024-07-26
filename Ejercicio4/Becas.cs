using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Becas
    {
        public Becas() { }
        public Becas(string codigo, DateTime fecha_Otorgamiento, Beneficiarios beneficiarios)
        {
            Codigo = codigo;
            Fecha_Otorgamiento = fecha_Otorgamiento;
            Beneficiarios = beneficiarios;
            pagado = false;
        }

        public string Codigo { get; set; }
        public DateTime Fecha_Otorgamiento { get; set; }
        public bool pagado { get; set; }
        public event EventHandler evento;
        decimal _importe;
        public decimal Importe
        {
            get { return _importe; }
            set
            {
                _importe = value;
                if (Beneficiarios != null) { if (value > Beneficiarios.Cuota) evento?.Invoke(this, null); }
            }
        }
        public Beneficiarios Beneficiarios { get; set; }
    }
}
