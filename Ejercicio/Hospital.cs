using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Hospital
    {
        List<Cliente> lClientes;
        List<Turno> lTurnos;

        public Hospital()
        {
            lClientes = new List<Cliente>();
            lTurnos = new List<Turno>();
        }
        public void AgregarCliente(Cliente pCliente)
        {
            lClientes.Add(pCliente);
        }
        public void EliminarCliente(Cliente pCliente)
        {
            lClientes.Remove(pCliente);
        }
        public List<Cliente> GetClientes()
        {
            return lClientes;
        }
        public void AgregarTurno(Turno pTurno)
        {
            lTurnos.Add(pTurno);
        }
        public void EliminarTurno(Turno pTurno)
        {
            lTurnos.Remove(pTurno);
        }
        public List<Turno> GetTurnos()
        {
            return lTurnos;
        }
    }
}
