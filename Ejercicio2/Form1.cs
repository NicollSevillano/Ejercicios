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
                if (!r.IsMatch(_codInvitacion)) throw new Exception("Codigo inválido");
                string _nombre = Interaction.InputBox("Nombre:");
                if (string.IsNullOrEmpty(_nombre)) MessageBox.Show("Nombre inválido");
                string _apellido = Interaction.InputBox("Apellido:");
                if (DateTime.TryParse(Interaction.InputBox("Fecha de Inicio"), out DateTime _inicio)) 

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
        public void RefrescarPelicula()
        {
            var aux = from p in _Premiacion.getPeliculas()
                      select new { p.id, p.pNombre, p.Genero, p.Director.Nombre, p.Estreno };
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = aux.ToList();
        }
        public void MostrarMsg(object sender, EventArgs e)
        {
            MessageBox.Show("La película es remasterizada");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Director _director = _Premiacion.getDirectores().Find(x => x.Nombre == dgvDirectores.SelectedRows[0].Cells[1].Value.ToString());
                if (pClasica.Checked == true)
                {
                    if (_director.lPelicula.Exists(x => x is pClasica))
                    {
                        throw new Exception("Este director ya tiene una película clásica");
                    }
                    string _Nombre = Interaction.InputBox("Nombre:");
                    if (string.IsNullOrEmpty(_Nombre)) throw new Exception("Nombre inválido");
                    if (DateTime.TryParse(Interaction.InputBox("Fecha de estreno:"), out DateTime _estreno)) ;
                    pClasica aux = new pClasica(_Nombre, Genero.Clasica, _director);
                    aux.Evento += MostrarMsg;
                    aux.Estreno = _estreno;
                    _Premiacion.AgregarPelicula(aux);
                    _director.lPelicula.Add(aux);
                    RefrescarPelicula();
                }
                if (pEstreno.Checked == true)
                {
                    if (_director.lPelicula.Exists(x => x is pEstreno))
                    {
                        throw new Exception("Este director ya tiene una película estreno");
                    }
                    string _Nombre = Interaction.InputBox("Nombre:");
                    if (string.IsNullOrEmpty(_Nombre)) throw new Exception("Nombre inválido");
                    pEstreno aux = new pEstreno(_Nombre, Genero.Estreno, _director);
                    _Premiacion.AgregarPelicula(aux);
                    _director.lPelicula.Add(aux);
                    RefrescarPelicula();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pelicula _pelicula = _Premiacion.getPeliculas().Find(x => x.id == int.Parse(dgvPeliculas.SelectedRows[0].Cells[0].Value.ToString()));
            _Premiacion.EliminarPelicula(_pelicula);
            RefrescarPelicula();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula aux = _Premiacion.getPeliculas().Find(x => x.id == int.Parse(dgvPeliculas.SelectedRows[0].Cells[0].Value.ToString()));
                if (aux is pClasica)
                {
                    string pNombre = Interaction.InputBox("Nombre:", "Modificando...", aux.pNombre);
                    if (DateTime.TryParse(Interaction.InputBox("Fecha de estreno", "Modificando...", aux.Estreno.ToShortDateString()), out DateTime _estreno)) ;

                    aux.pNombre = pNombre;
                    aux.Estreno = _estreno;
                    RefrescarPelicula();
                }
                if(aux is pEstreno)
                {
                    string pNombre = Interaction.InputBox("Nombre:", "Modificando...", aux.pNombre);
                    aux.pNombre = pNombre;
                    RefrescarPelicula();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefrescarPelicula(List<Pelicula> lPelicula)
        {
            var aux = from p in lPelicula
                      select p;
            dgvPeliculas.DataSource = null;
            dgvPeliculas.DataSource = aux.ToList();
        }
        private void btnMPelicula_Click(object sender, EventArgs e)
        {
            List<Pelicula> aux = _Premiacion.getPeliculas();
            if(pAscendente.Checked == true) { aux.Sort(new PeliculaASC()); }
            else { aux.Sort(new PeliculaDESC()); }
            RefrescarPelicula();
        }
    }
}
