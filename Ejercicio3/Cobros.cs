using Ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public abstract class Cobros
    {
        public Cobros() { }
        public int Codigo { get; set; }
        public static int cod = 1;
        public string NombreCobro { get; set; }
        public DateTime fVencimiento { get; set; }
        decimal _Pagar;
        //Declaracion
        public event EventHandler evento;
        public decimal ImporteCobrar { get; set; }
        public decimal Recargo 
        {
            get { return _Pagar; }
            set
            {
                _Pagar = value;
                //Desebcadena
                if (value + this.ImporteCobrar > 10000) evento?.Invoke(this, null);
            }
        }
        public Cliente Cliente { get; set; }
        public bool Pagado { get; set; }
        public abstract decimal CalcularRecargo();

        //Compare
        public class CAscendente : IComparer<Cobros>
        {
            public int Compare(Cobros x, Cobros y)
            {
                return decimal.Compare(x.ImporteCobrar, y.ImporteCobrar);
            }
        }
        public class CDescendente : IComparer<Cobros>
        {
            public int Compare(Cobros x, Cobros y)
            {
                return decimal.Compare(x.ImporteCobrar, y.ImporteCobrar) * -1;
            }
        }
    }
    public class Normal : Cobros
    {
        public Normal(string pNombre, DateTime pVencimiento, decimal pImporteCobrar, Cliente pCliente)
        {
            Codigo = cod;
            cod++;
            NombreCobro = pNombre;
            fVencimiento = pVencimiento; ImporteCobrar = pImporteCobrar;
            Cliente = pCliente;
            Recargo = 0;
            Pagado = false;
        }

        public override decimal CalcularRecargo()
        {
            return ImporteCobrar * 0.1M;
        }
    }
    public class Especial : Cobros
    {
        public Especial(string pNombre, DateTime pVencimiento, decimal pImporteCobrar, Cliente pCliente)
        {
            Codigo = cod;
            cod++;
            NombreCobro = pNombre;
            fVencimiento = pVencimiento; ImporteCobrar = pImporteCobrar;
            Cliente = pCliente;
            Recargo = 0;
            Pagado = false;
        }

        public override decimal CalcularRecargo()
        {
            return ImporteCobrar * 0.2M;
        }
    }
}
