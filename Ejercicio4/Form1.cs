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
using System.Runtime.InteropServices;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Beneficiarios> lBbeneficiarios;
        Regex r;
        private void Form1_Load(object sender, EventArgs e)
        {
            lBbeneficiarios = new List<Beneficiarios>();
            r = new Regex(@"(\d{4}[A-Z]{2})");
        }
        //Beneficiarios
        public void RefrescarAlumno()
        {
            var aux = from alum in lBbeneficiarios
                      select new { alum.Legajo, alum.Nombre, alum.Apellido, alum.Dni, alum.Tipo_Beneficio, alum.Cuota };
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = aux.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbIngresantes.Checked == true)
                {
                    string pLegajo = Interaction.InputBox("Legajo:");
                    string pNombre = Interaction.InputBox("Nombre:");
                    string pApellido = Interaction.InputBox("Apellido:");
                    string pDni = Interaction.InputBox("Dni:");
                    string pBeneficio = Interaction.InputBox("Tipo:");
                    decimal pCuota = decimal.Parse(Interaction.InputBox("Cuota:"));

                    lBbeneficiarios.Add(new Ingresante(pLegajo, pNombre, pApellido, pDni, pBeneficio, pCuota));
                    RefrescarAlumno();
                }
                if(rbGrado.Checked == true)
                {
                    string pLegajo = Interaction.InputBox("Legajo:");
                    string pNombre = Interaction.InputBox("Nombre:");
                    string pApellido = Interaction.InputBox("Apellido:");
                    string pDni = Interaction.InputBox("Dni:");
                    string pBeneficio = Interaction.InputBox("Tipo:");
                    decimal pCuota = decimal.Parse(Interaction.InputBox("Cuota:"));

                    lBbeneficiarios.Add(new Grado(pLegajo, pNombre, pApellido, pDni, pBeneficio, pCuota));
                    RefrescarAlumno();
                }
                if(rbPosgrado.Checked == true)
                {
                    string pLegajo = Interaction.InputBox("Legajo:");
                    string pNombre = Interaction.InputBox("Nombre:");
                    string pApellido = Interaction.InputBox("Apellido:");
                    string pDni = Interaction.InputBox("Dni:");
                    string pBeneficio = Interaction.InputBox("Tipo:");
                    decimal pCuota = decimal.Parse(Interaction.InputBox("Cuota:"));

                    lBbeneficiarios.Add(new Posgrado(pLegajo, pNombre, pApellido, pDni, pBeneficio, pCuota));
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
            Beneficiarios bene = lBbeneficiarios.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            lBbeneficiarios.Remove(bene);
            RefrescarAlumno();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Beneficiarios bene = lBbeneficiarios.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            string _Nombre = Interaction.InputBox("Nombre:", "Modificando...", bene.Nombre);
            string _Apellido = Interaction.InputBox("Apellido:", "Modificando...", bene.Apellido);
            string _Dni = Interaction.InputBox("Dni:", "Modificando...", bene.Dni);
            string _Beneficio = Interaction.InputBox("Tipo:", "Modificando...", bene.Tipo_Beneficio);
            bene.Nombre = _Nombre;
            bene.Apellido = _Apellido;
            bene.Dni = _Dni;
            bene.Tipo_Beneficio = _Beneficio;
            RefrescarAlumno();
        }
        //Becas
        public void RefrescarBeca()
        {
            List<Becas> lBeca = new List<Becas>();
            foreach(Beneficiarios b in lBbeneficiarios)
            {
                lBeca.Add(b.BecaBeneficiario);
            }
            var aux = from beca in lBeca
                      select new { beca.Codigo, beca.Fecha_Otorgamiento, beca.Importe, beca.Beneficiarios.Legajo, beca.pagado };
            dgvBecas.DataSource = null;
            dgvBecas.DataSource = aux.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string _Codigo = Interaction.InputBox("Código:");
                if (!r.IsMatch(_Codigo)) throw new Exception("Los código son: 4 números y 2 letras");
                DateTime fechaOtor = DateTime.Parse(Interaction.InputBox("Fecha de otorgamiento:"));
                decimal Importe = decimal.Parse(Interaction.InputBox("Importe:"));
                Beneficiarios bene = lBbeneficiarios.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());

                Becas b = new Becas(_Codigo, fechaOtor, bene);
                b.evento += EventoCuota;
                b.Importe = Importe;
                bene.BecaBeneficiario = b;
                RefrescarBeca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EventoCuota(object sender, EventArgs e)
        {
            throw new Exception("La beca no debe superar el 100% de la cuota del alumno");
        }

        //Pagar
        private void button5_Click(object sender, EventArgs e)
        {
            Beneficiarios bene = lBbeneficiarios.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            string pago = dgvBecas.SelectedRows[0].Cells[0].Value.ToString();
            decimal aux = bene.Pagar(pago);
            MessageBox.Show($"Se pagó: {aux}");
            RefrescarAlumno();
            RefrescarBeca();
        }
        //DGV 3
        public void Refrescar()
        {
            if (lBbeneficiarios.Count == 0) return;
            Beneficiarios bene = lBbeneficiarios.Find(x => x.Legajo == dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            if (bene.BecaBeneficiario == null) return;
            List<Becas> beca = new List<Becas>();
            beca.Add(bene.BecaBeneficiario);
            var aux = from b in beca
                      select new { b.Codigo, b.Fecha_Otorgamiento, b.Importe };
            dgvPagar.DataSource = null;
            dgvPagar.DataSource = aux.ToList();
        }
        private void dgvAlumnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(lBbeneficiarios == null) return;
                Refrescar();
            }
            catch (Exception)
            {

            }
        }
    }
}
