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
using System.Text.RegularExpressions;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Regex r;
        Premiacion _Premiacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Premiacion = new Premiacion();
            r = new Regex(@"([a-z][A-Z]\d{2})");
        }
        public void RefrescarDirector()
        {
            var aux = from director in _Premiacion.getDirectores()
                      select director;
            dgvDirectores.DataSource = null;
            dgvDirectores.DataSource = aux.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string _codInvitacion = Interaction.InputBox("Codigo de invitación:");
                if (!r.IsMatch(_codInvitacion)) MessageBox.Show("Codigo inválido"); return;
                string _nombre = Interaction.InputBox("Nombre:");
                if (string.IsNullOrEmpty(_nombre)) MessageBox.Show("Nombre inválido"); return; 
                string _apellido = Interaction.InputBox("Apellido:");
                if (DateTime.TryParse(Interaction.InputBox("Fecha de Inicio"), out DateTime _inicio)) MessageBox.Show("Cadena inválida"); return;

                _Premiacion.AgregarDirector(new Director(_codInvitacion, _nombre, _apellido, _inicio));
                RefrescarDirector();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Director aux = dgvDirectores.SelectedRows[0].DataBoundItem as Director;
            _Premiacion.EliminarDirector(aux);
            RefrescarDirector();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Director aux = dgvDirectores.SelectedRows[0].DataBoundItem as Director;
            string _nombre = Interaction.InputBox("Nombre:", "Modificando...", aux.Nombre);
            string _apellido = Interaction.InputBox("Apellido", "Modificando...", aux.Apellido);
            DateTime _inicio = DateTime.Parse(Interaction.InputBox("Fecha de inicio","Modificando...",aux.Inicio.ToShortDateString()));  

            aux.Nombre = _nombre;
            aux.Apellido = _apellido;
            aux.Inicio = _inicio;
            RefrescarDirector();
        }
        public void RefrescarDirector(List<Director> lDirector)
        {
            var aux = from director in lDirector
                      select director;
            dgvDirectores.DataSource = null;
            dgvDirectores.DataSource = aux.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            List<Director> aux = _Premiacion.getDirectores();
            if(radioButton1.Checked == true) { aux.Sort(new DirectorASC()); }
            else { aux.Sort(new DirectorDESC()); }
            RefrescarDirector(aux);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
