using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Alumno> alumnoList;
        private void Form1_Load(object sender, EventArgs e)
        {
            alumnoList = new List<Alumno>();
        }
        //Alumno
        public void RefrescarAlumno()
        {
            var aux = from al in alumnoList
                      select new { al.Id, al.Documento, al.Numero_Documento, al.Nombre, al.Apellido};
            dgvAlumno.DataSource = null;
            dgvAlumno.DataSource = aux.ToList();
        }
        private void btnAltaA_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbExtranjero.Checked == true)
                {
                    string _Id = Interaction.InputBox("ID:");
                    string _Documento = Interaction.InputBox("Tipo documento");
                    string _Numero = Interaction.InputBox("Número de documento");
                    string _Nombre = Interaction.InputBox("Nombre:");
                    string _Apellido = Interaction.InputBox("Apellido");
                    string _Universidad = Interaction.InputBox("Nombre de la Universidad");
                    int _Cantidad = int.Parse(Interaction.InputBox("Cantidad de materias"));

                    alumnoList.Add(new Extranjero(_Id, _Documento, _Numero, _Nombre, _Apellido, _Universidad, _Cantidad));
                    RefrescarAlumno();
                }
                if(rbNacional.Checked == true)
                {
                    string _Id = Interaction.InputBox("ID:");
                    string _Documento = Interaction.InputBox("Tipo documento");
                    string _Numero = Interaction.InputBox("Número de documento");
                    string _Nombre = Interaction.InputBox("Nombre:");
                    string _Apellido = Interaction.InputBox("Apellido");

                    alumnoList.Add(new Nacional(_Id,_Documento, _Numero, _Nombre, _Apellido));
                    RefrescarAlumno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaA_Click(object sender, EventArgs e)
        {
            Alumno aux = alumnoList.Find(x => x.Id == dgvAlumno.SelectedRows[0].Cells[0].Value.ToString());
            alumnoList.Remove(aux);
            RefrescarAlumno();
            RefrescarTelefono();
        }

        private void btnModificarA_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno aux = alumnoList.Find(x => x.Id == dgvAlumno.SelectedRows[0].Cells[0].Value.ToString());
                if (aux is Extranjero)
                {
                    aux.Numero_Documento = Interaction.InputBox("Número de documento:", "Modificando...", aux.Numero_Documento);
                    aux.Nombre = Interaction.InputBox("Nombre:", "Modificando...", aux.Nombre);
                    aux.Apellido = Interaction.InputBox("Apellido:", "Modificando....", aux.Apellido);
                    (aux as Extranjero).Universidad = Interaction.InputBox("Universidad", "Modificando...", (aux as Extranjero).Universidad);
                    (aux as Extranjero).Cant_Materias = int.Parse(Interaction.InputBox("Cantidad de materias:", "Modificando...", (aux as Extranjero).Cant_Materias.ToString()));
                    RefrescarAlumno();
                    RefrescarTelefono();
                }
                if(aux is Nacional)
                {
                    aux.Numero_Documento = Interaction.InputBox("Número de documento:", "Modificando...", aux.Numero_Documento);
                    aux.Nombre = Interaction.InputBox("Nombre:", "Modificando...", aux.Nombre);
                    aux.Apellido = Interaction.InputBox("Apellido:", "Modificando....", aux.Apellido);
                    RefrescarAlumno();
                    RefrescarTelefono();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }
        //Teléfono
        public void RefrescarTelefono()
        {
            List<Telefono> telefonoList = new List<Telefono>();
            foreach (Alumno al in alumnoList)
            {
                telefonoList.AddRange(al.TelefonoList);
            }
            var aux = from tel in telefonoList
                      select new { tel.CodigoPais, tel.Numero, tel.Alumno.Apellido};
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = telefonoList.ToList();
        }
        public void eventoTelefonos(object sender, EventArgs e)
        {
            throw new Exception("El alumno puede tener un máximo de 2 teléfonos");
        }
        private void btnAltaT_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno al = alumnoList.Find(x => x.Id == dgvAlumno.SelectedRows[0].Cells[0].Value.ToString());
                al.Cantidad_Telefono++;
                string _CodPais = Interaction.InputBox("Código país:");
                int _Numero = int.Parse(Interaction.InputBox("Número de teléfono:"));

                Telefono aux = new Telefono(_CodPais, _Numero, al);
                al.evento += eventoTelefonos;
                al.TelefonoList.Add(aux);
                RefrescarTelefono();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //RowEnter
        public void Refrescar()
        {
            if (alumnoList.Count == 0) return;
            Alumno al = alumnoList.Find(x => x.Id == dgvAlumno.SelectedRows[0].Cells[0].Value.ToString());
            if (al.TelefonoList == null) return;
            var aux = from alum in al.TelefonoList
                      select new { alum.Alumno.Nombre, alum.Alumno.Apellido, alum.Alumno.Numero_Documento, alum.Numero };
            dgvRE.DataSource = null;
            dgvRE.DataSource = aux.ToList();
        }
        private void dgvAlumno_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (alumnoList == null) return;
                Refrescar();
            }
            catch (Exception) { }
        }
        //Orden
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(rbAsc.Checked == true)
            {
                alumnoList.Sort(new AlumnoAsc());
                RefrescarAlumno();
            }
            else
            {
                alumnoList.Sort(new AlumnoDesc());
                RefrescarAlumno();
            }
        }
    }
}
