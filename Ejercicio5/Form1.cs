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

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Alumno> lAlumno;
        Regex r;
        private void Form1_Load(object sender, EventArgs e)
        {
            lAlumno = new List<Alumno>();
            r = new Regex(@"\d{4}[a-z]{2}");
        }
        //Alumnos
        public void RefrescarAlumno()
        {
            var aux = from alumno in lAlumno
                      select new { alumno.Legajo, alumno.Nombre, alumno.Apellido, alumno.DNI, alumno.Cuota };
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = aux.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbIngresante.Checked == true)
                {
                    string _Legajo = Interaction.InputBox("Legajo:", "Alta");
                    string _Nombre = Interaction.InputBox("Nombre:", "Alta");
                    string _Apellido = Interaction.InputBox("Apellido:", "Alta");
                    string _Dni = Interaction.InputBox("DNI:", "Alta");
                    decimal _Cuota = decimal.Parse(Interaction.InputBox("Cuota:", "Alta"));

                    lAlumno.Add(new bIngresante(_Legajo, _Nombre, _Apellido, _Dni, _Cuota));
                    RefrescarAlumno();
                }
                if (rbGrado.Checked == true)
                {
                    string _Legajo = Interaction.InputBox("Legajo:", "Alta");
                    string _Nombre = Interaction.InputBox("Nombre:", "Alta");
                    string _Apellido = Interaction.InputBox("Apellido:", "Alta");
                    string _Dni = Interaction.InputBox("DNI:", "Alta");
                    decimal _Cuota = decimal.Parse(Interaction.InputBox("Cuota:", "Alta"));

                    lAlumno.Add(new bGrado(_Legajo, _Nombre, _Apellido, _Dni, _Cuota));
                    RefrescarAlumno();
                }
                if (rbPosgrado.Checked == true)
                {
                    string _Legajo = Interaction.InputBox("Legajo:", "Alta");
                    string _Nombre = Interaction.InputBox("Nombre:", "Alta");
                    string _Apellido = Interaction.InputBox("Apellido:", "Alta");
                    string _Dni = Interaction.InputBox("DNI:", "Alta");
                    decimal _Cuota = decimal.Parse(Interaction.InputBox("Cuota:", "Alta"));

                    lAlumno.Add(new bPosgrado(_Legajo, _Nombre, _Apellido, _Dni, _Cuota));
                    RefrescarAlumno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumno aux = lAlumno.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            lAlumno.Remove(aux);
            RefrescarAlumno();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alumno aux = lAlumno.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            string _Nombre = Interaction.InputBox("Nombre:", "Modificando...", aux.Nombre);
            string _Apellido = Interaction.InputBox("Apellido:", "Modificando...", aux.Apellido);
            string _Dni = Interaction.InputBox("DNI:", "Modificando...", aux.DNI);
            aux.Nombre = _Nombre;
            aux.Apellido = _Apellido;
            aux.DNI = _Dni;
            RefrescarAlumno();
        }
        //Becas
        public void RefrescarBeca()
        {
            List<Beca> lBeca = new List<Beca>();
            foreach (Alumno al in lAlumno)
            {
                lBeca.AddRange(al.Beca);
            }
            var aux = from b in lBeca
                      select new { b.Codigo, b.Fecha_Otorgamiento, b.Importe, b.Alumno.Nombre };
            dgvBecas.DataSource = null;
            dgvBecas.DataSource = aux.ToList();
        }
        public void eventoCantidadBecas(object sender, EventArgs e)
        {
            throw new Exception("El alumno solo puede tener un máximo de 2 becas");
        }
        public void eventoImporte(object sender, EventArgs e)
        {
            throw new Exception("El importe de la beca no debe superar el 100% de la cuota del alumno");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno _Alumno = lAlumno.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
                _Alumno.Cantidad_Beca++;
                string _Codigo = Interaction.InputBox("Código beca:", "Alta");
                if (!r.IsMatch(_Codigo)) throw new Exception("El código de la beca tiene que ser: 4 primeros números y 2 letras (minúsculas)");
                DateTime _Fecha_Otorgamiento = DateTime.Parse(Interaction.InputBox("Fecha de otorgamiento:", "Alta"));
                decimal _Importe = decimal.Parse(Interaction.InputBox("Importe:", "Alta"));

                Beca aux = new Beca(_Codigo, _Fecha_Otorgamiento, _Importe, _Alumno);
                _Alumno.evento += eventoCantidadBecas;
                aux.evento += eventoImporte;
                aux.Importe = _Importe;
                _Alumno.Beca.Add(aux);
                RefrescarBeca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Pagar
        private void button5_Click(object sender, EventArgs e)
        {
            Alumno al = lAlumno.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            string pago = dgvBecas.SelectedRows[0].Cells[0].Value.ToString();
            decimal aux = al.Cobrar(pago);
            MessageBox.Show($"Se pagó {aux}");
            RefrescarAlumno();
            RefrescarBeca();
            refresercarRowEnter();
            RefrescarBecaRowEnter();
        }
        //Actualizar grilla 
        public void refresercarRowEnter()
        {
            if (lAlumno.Count == 0) return;
            Alumno al = lAlumno.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            if (al.Beca == null) return;
            List<Beca> lBeca = new List<Beca>();
            lBeca.AddRange(al.Beca);
            var aux = from beca in lBeca
                      select new { beca.Codigo, beca.Fecha_Otorgamiento, beca.Importe };
            dgvActualizarRE.DataSource = null;
            dgvActualizarRE.DataSource = aux.ToList();
        }
        public void RefrescarBecaRowEnter()
        {
            if (lAlumno.Count == 0) return;
            Alumno al = lAlumno.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            if (al.Beca == null) return;
            var aux = from b in al.Beca
                      select new { b.Codigo, b.Fecha_Otorgamiento.Date.Month, b.Alumno.Cuota , b.Importe, b.Alumno.Beneficio, b.Neto };
            dgvTotal.DataSource = null;
            dgvTotal.DataSource = aux.ToList();
        }
        private void dgvAlumnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (lAlumno == null) return;
                refresercarRowEnter();
                RefrescarBecaRowEnter();
            }
            catch (Exception)
            {

            }
        }
    }
}

