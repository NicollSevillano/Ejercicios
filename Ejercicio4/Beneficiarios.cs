using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public abstract class Beneficiarios
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Tipo_Beneficio { get; set; }
        public Becas BecaBeneficiario {  get; set; }
        public decimal Cuota { get; set; }
        public abstract decimal Pagar(string pid);
    }
    public class Ingresante : Beneficiarios
    {
        public Ingresante(string pLegajo, string pNombre, string pApellido, string pDni, string pTipoBeneficio, decimal pCuota)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; Dni = pDni; Tipo_Beneficio = pTipoBeneficio; Cuota = pCuota;
        }

        public override decimal Pagar(string pid)
        {
            decimal _pagar = (Cuota - BecaBeneficiario.Importe) * 0.9M;
            BecaBeneficiario.pagado = true;
            return _pagar;
        }
    }
    public class Grado : Beneficiarios
    {
        public Grado(string pLegajo, string pNombre, string pApellido, string pDni, string pTipoBeneficio, decimal pCuota)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; Dni = pDni; Tipo_Beneficio = pTipoBeneficio; Cuota = pCuota;
        }

        public override decimal Pagar(string pid)
        {
            decimal _pagar = (Cuota - BecaBeneficiario.Importe) * 0.5M;
            BecaBeneficiario.pagado = true;
            return _pagar;
        }
    }
    public class Posgrado : Beneficiarios
    {
        public Posgrado(string pLegajo, string pNombre, string pApellido, string pDni, string pTipoBeneficio, decimal pCuota)
        {
            Legajo = pLegajo; Nombre = pNombre; Apellido = pApellido; Dni = pDni; Tipo_Beneficio = pTipoBeneficio; Cuota = pCuota;
        }

        public override decimal Pagar(string pid)
        {
            decimal _pagar = (Cuota - BecaBeneficiario.Importe) * 0.01M;
            BecaBeneficiario.pagado = true;
            return _pagar;
        }
    }
}
