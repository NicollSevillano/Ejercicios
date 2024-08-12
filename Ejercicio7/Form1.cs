using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cliente> lCliente;
        private void Form1_Load(object sender, EventArgs e)
        {
            lCliente = new List<Cliente>();
        }
        public void RefrescarCliente()
        {
            var aux = from c in lCliente select new { c.id, c.Nombre, c.Apellido, c.DNI };
            dgvCliente.DataSource = null; dgvCliente.DataSource = aux.ToList();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre:");
                string apellido = Interaction.InputBox("Apellido:");
                string dni = Interaction.InputBox("DNI:");
                lCliente.Add(new Cliente() { Nombre = nombre, Apellido = apellido, DNI = dni });
                RefrescarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            Cliente aux = lCliente.Find(x => x.id == int.Parse(dgvCliente.SelectedRows[0].Cells[0].Value.ToString()));
            lCliente.Remove(aux);
            RefrescarCliente();
        }
    }
}
