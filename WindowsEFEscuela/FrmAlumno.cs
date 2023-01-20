using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // creamos ub objeto de instancia alumno que toma los datos
            Alumno alumno1 = new Alumno() { Name = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(dateTimePicker.Value) };

            int filasAfectadas = AbmAlumno.Insert(alumno1);

            if (filasAfectadas > 0 ) 
            {
                MessageBox.Show("Insert ok");
            }
        }

        private void VerTodo(object sender, EventArgs e)
        {
            GridCategoria.DataSource = AbmAlumno.SelectAll();
        }

        private void BtnModificar(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno() { AlumnoId = Convert.ToInt16(txtId.Text), Name = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(dateTimePicker.Value) };

            int filasAfectadas = AbmAlumno.Update(alumno1);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Alumno alumno1 = new Alumno() { AlumnoId = Convert.ToInt16(txtId.Text) };

            int filasAfectadas = AbmAlumno.Delete(alumno1);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
            }
        }

        private void buscarPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            

            Alumno alumno1 = AbmAlumno.SelectById(id);
            MessageBox.Show(alumno1.Name + "\n" + alumno1.Apellido);

        }
    }
}
