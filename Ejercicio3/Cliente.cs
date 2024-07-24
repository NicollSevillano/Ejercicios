using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Cliente
    {
        public Cliente(string pLegajo, string pNombre)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Cobro = new List<Cobros>();
        }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public List<Cobros> Cobro { get; set; }
        
        public void Cobrar(int pId)
        {
            Cobros aux = Cobro.Find(x => x.Codigo == pId);
            if (aux == null) return;
            aux.Recargo = aux.CalcularRecargo();
            aux.Pagado = true;
        }
    }
}
