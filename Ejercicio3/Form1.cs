using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cliente> clienteList;

        private void Form1_Load(object sender, EventArgs e)
        {
            clienteList = new List<Cliente>();
        }
        //Cliente
        public void MostrarCliente()
        {
            var aux = from cliente in clienteList
                      select cliente;
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = aux.ToList();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            string _legajo = Interaction.InputBox("Legajo:");
            string _nombre = Interaction.InputBox("Nombre:");

            clienteList.Add(new Cliente(_legajo, _nombre));
            MostrarCliente();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Cliente _cliente = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
            clienteList.Remove(_cliente);
            MostrarCliente();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente _cliente = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
            string _nombre = Interaction.InputBox("Nombre:", "Modificando...", _cliente.Nombre);

            _cliente.Nombre = _nombre;
            MostrarCliente();
        }
        //Cobros
        public void RefrescarCobro()
        {
            List<Cobros> lcobro = new List<Cobros>();
            foreach (Cliente p in clienteList)
            {
                lcobro.AddRange(p.Cobro);
            }
            var aux = from cobro in lcobro
                      select new { cobro.Codigo, cobro.NombreCobro, cobro.fVencimiento, cobro.ImporteCobrar, cobro.Cliente.Nombre, cobro.Pagado };
            dgvCobros.DataSource = null;
            dgvCobros.DataSource = aux.ToList();
        }

        private void btnAltaCobro_Click(object sender, EventArgs e)
        {
            if (rbNormales.Checked == true)
            {
                string _nombre = Interaction.InputBox("Nombre:");
                DateTime _vencimiento = DateTime.Parse(Interaction.InputBox("Fecha de vencimiento:"));
                decimal _importe = decimal.Parse(Interaction.InputBox("Importe a cobrar:"));
                Cliente _cliente = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());

                Normal aux = new Normal(_nombre, _vencimiento, _importe, _cliente);
                //Subscripción
                aux.evento += EventoPagar;
                _cliente.Cobro.Add(aux);
                RefrescarCobro();
            }
            if (rbEspeciales.Checked == true)
            {
                string _nombre = Interaction.InputBox("Nombre:");
                DateTime _vencimiento = DateTime.Parse(Interaction.InputBox("Fecha de vencimiento:"));
                decimal _importe = decimal.Parse(Interaction.InputBox("Importe a cobrar:"));
                Cliente _cliente = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());

                Especial aux = new Especial(_nombre, _vencimiento, _importe, _cliente);
                //Subscripción
                aux.evento += EventoPagar;
                _cliente.Cobro.Add(aux);
                RefrescarCobro();
            }
        }

        private void Aux_evento(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Cobros pagados
        public void RefrescarPagos()
        {
            Cliente aux1 = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
            var aux = from c in aux1.Cobro
                      where c.Pagado == true
                      select new { c.Codigo, c.NombreCobro, c.fVencimiento, c.ImporteCobrar, c.Cliente.Nombre, c.Pagado, total = c.ImporteCobrar + c.Recargo };
            dgvPagados.DataSource = null;
            dgvPagados.DataSource = aux.ToList();
        }
        //Evento
        public void EventoPagar(object sender, EventArgs e)
        {
            MessageBox.Show("El total a pagar es mayor a $10.000");
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            Cliente aux = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
            int _cobrar = int.Parse(dgvCobros.SelectedRows[0].Cells[0].Value.ToString());
            aux.Cobrar(_cobrar);
            RefrescarCobro();
            RefrescarPagos();
        }
        //Orden
        public void RefrescarOrden()
        {
            Cliente aux1 = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
            var aux = from c in aux1.Cobro
                      where c.Pagado == true
                      select new { c.Codigo, c.NombreCobro, c.fVencimiento, c.ImporteCobrar, c.Cliente.Nombre, c.Pagado };
            dgvOrden.DataSource = null;
            dgvOrden.DataSource = aux.ToList();
        }

        private void btnMostarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente aux1 = clienteList.Find(x => x.Legajo == dgvCliente.SelectedRows[0].Cells[0].Value.ToString());
                List<Cobros> aux = aux1.Cobro;
                if (rbAscendente.Checked == true)
                { aux.Sort(new Cobros.CAscendente()); }
                else
                { aux.Sort(new Cobros.CDescendente()); }
                RefrescarOrden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefrescarMostrar()
        {
            List<Cobros> lcobro = new List<Cobros>();
            foreach (Cliente p in clienteList)
            {
                lcobro.AddRange(p.Cobro);
            }
            var aux = from c in lcobro
                      where c.Pagado == true
                      select new { c.Cliente.Nombre, total = c.ImporteCobrar + c.Recargo };
            dgvCCancelados.DataSource = null;
            dgvCCancelados.DataSource = aux.ToList();
        }

        private void btnMostrarCobroCancelado_Click(object sender, EventArgs e)
        {
            RefrescarMostrar();
        }
    }
}
