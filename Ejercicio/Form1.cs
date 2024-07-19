using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hospital _hospital;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _hospital = new Hospital();
        }
        
        public void RefrescarCliente()
        {
            var aux = from cliente in _hospital.GetClientes()
                      select cliente;
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = aux.ToList();
        }
        public void RefrescarTurno()
        {
            var aux = from turno in _hospital.GetTurnos()
                      select new { turno.id, turno.Fecha, turno.Cliente.Nombre };
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = aux.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _dni = Interaction.InputBox("DNI:");
                if (!Information.IsNumeric(_dni)) throw new Exception("El dni tiene que ser numérico");
                if (string.IsNullOrEmpty(_dni)) throw new Exception("DNI no válido");
                string _nombre = Interaction.InputBox("Nombre:");
                string _apellido = Interaction.InputBox("Apellido:");

                _hospital.AgregarCliente(new Cliente(_dni, _nombre, _apellido));
                RefrescarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = dgvCliente.SelectedRows[0].DataBoundItem as Cliente;
            _hospital.EliminarCliente(cliente);
            RefrescarCliente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cliente = dgvCliente.SelectedRows[0].DataBoundItem as Cliente;
            string _dni = Interaction.InputBox("DNI:", "Modificando...", cliente.DNI);
            string _nombre = Interaction.InputBox("Nombre:", "Modificando...", cliente.Nombre);
            string _apellido = Interaction.InputBox("Apellido:", "Modificando...", cliente.Apellido);

            cliente.DNI = _dni;
            cliente.Nombre = _nombre;
            cliente.Apellido = _apellido;
            RefrescarCliente();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = _hospital.GetClientes().Find(x => x.Nombre == dgvCliente.SelectedRows[0].Cells[1].Value.ToString());
            DateTime fecha = DateTime.Parse(Interaction.InputBox("Fecha:"));

            _hospital.AgregarTurno(new Turno(fecha, cliente));
            RefrescarTurno();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Turno turno = _hospital.GetTurnos().Find(x => x.id == int.Parse(dgvTurnos.SelectedRows[0].Cells[0].Value.ToString()));
            _hospital.EliminarTurno(turno);
            RefrescarTurno();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Turno turno = _hospital.GetTurnos().Find(x => x.id == int.Parse(dgvTurnos.SelectedRows[0].Cells[0].Value.ToString()));
            DateTime _fecha = DateTime.Parse(Interaction.InputBox("Fecha:","Modificando...",turno.Fecha.ToShortDateString()));
            turno.Fecha = _fecha;
            RefrescarTurno();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Turno turno = _hospital.GetTurnos().Find(x => x.id == int.Parse(dgvTurnos.SelectedRows[0].Cells[0].Value.ToString()));
            listBox1.Items.Add($"Id de turno: {turno.id}");
            listBox1.Items.Add($"Fecha: {turno.Fecha.ToShortDateString()}");
            listBox1.Items.Add($"DNI: {turno.Cliente.DNI}");
            listBox1.Items.Add($"Nombre: {turno.Cliente.Nombre}");
            listBox1.Items.Add($"Apellido: {turno.Cliente.Apellido}");
        }
        public void RefrescarTurno(List<Turno> pLista)
        {
            var aux = from turno in pLista
                      select new { turno.id, turno.Fecha, turno.Cliente.Nombre };
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = aux.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Turno> aux = _hospital.GetTurnos();
            if (radioButton1.Checked == true) { aux.Sort(new Turno.TurnoASC()); }
            else { aux.Sort(new Turno.TurnoDESC()); }
            RefrescarTurno(aux); 
        }
    }
}
