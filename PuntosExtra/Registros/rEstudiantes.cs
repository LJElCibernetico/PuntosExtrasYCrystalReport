using PuntosExtra.Consultas;
using PuntosExtra.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntosExtra.Registros
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEstudiantes ce = new cEstudiantes();
            ce.Show();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(estudiantesIDtextBox.Text, out ID);

            estudiante = BLL.EstudiantesBLL.Buscar(ID);

            if (estudiante != null)
            {
                MessageBox.Show("Estudiante Encontado");
                nombrestextBox.Text = estudiante.nombre;
                observacionestextBox.Text = estudiante.observaciones;
                fechadateTimePicker.Value = estudiante.fecha;

            }
            else
            {
                MessageBox.Show("Estudiante No Encontado");
            }
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = LlenaClase();

            if (nombrestextBox.Text == string.Empty || observacionestextBox.Text == string.Empty || fechadateTimePicker.Text == string.Empty)
                validarerrorProvider.SetError(guardarbutton, "Usted dejo algo vacio, completelo e intente guardar nuevamente");
            else if (BLL.EstudiantesBLL.Guardar(estudiante))
                MessageBox.Show("Estudiante Guardado");

            LimpiarTextBox();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            int a;
            int.TryParse(estudiantesIDtextBox.Text, out a);
            estudiante.estudianteID = a;
            estudiante.nombre = nombrestextBox.Text;
            estudiante.observaciones = observacionestextBox.Text;
            estudiante.fecha = fechadateTimePicker.Value;
            return estudiante;
        }

        private void LimpiarTextBox()
        {
            estudiantesIDtextBox.Clear();
            fechadateTimePicker.Value = DateTime.Now;
            nombrestextBox.Clear();
            observacionestextBox.Clear();
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(estudiantesIDtextBox.Text, out ID);

            if (BLL.EstudiantesBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                validarerrorProvider.SetError(eliminarbutton ,"No se puede eliminar un estudiante que no existe");
            }
        }

        private void rEstudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
