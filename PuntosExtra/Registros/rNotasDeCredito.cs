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
    public partial class rNotasDeCredito : Form
    {
        public rNotasDeCredito()
        {
            InitializeComponent();
        }

        private void guardarbutton_Click(object sender, EventArgs e)
        {
            int ID, ID1;
            int.TryParse(idnumericUpDown.Text, out ID);
            int.TryParse(estudianteidnumericUpDown.Text, out ID1);
            NotasDeCredito nc = BLL.NotasDeCreditoBLL.Buscar(ID);
            Estudiantes es = BLL.EstudiantesBLL.Buscar(ID1);
            if (nc == null)
            {
                NotasDeCredito nc1 = LlenarClase();
                es.montoDescuento += nc1.monto;

                if (fechadateTimePicker.Text == string.Empty || estudianteidnumericUpDown.Value == 0 || 
                    nombretextBox.Text == string.Empty || montoasignaturasnumericUpDown.Value == 0 || 
                    pctnumericUpDown.Value == 0 || montotextBox.Text == string.Empty)
                    ValidarerrorProvider.SetError(guardarbutton, "No puede dejar nada vacio");
                else if (BLL.NotasDeCreditoBLL.Guardar(nc1))
                    MessageBox.Show("Nota de Credito Guardada");
                else if (!BLL.NotasDeCreditoBLL.Guardar(nc1))
                    MessageBox.Show("Nota de Credito No Guardada");
            }
            else
            {
                nc.fecha = fechadateTimePicker.Value;
                nc.estudianteID = int.Parse(estudianteidnumericUpDown.Text);
                nc.montoAsignatura = montoasignaturasnumericUpDown.Value;
                nc.pctBeca = pctnumericUpDown.Value;
                nc.monto = (montoasignaturasnumericUpDown.Value - (montoasignaturasnumericUpDown.Value * (pctnumericUpDown.Value / 100)));
                es.montoDescuento += nc.monto;

                if (BLL.NotasDeCreditoBLL.Modificar(nc))
                    MessageBox.Show("Acaba de Modificar La Nota De Credito");
                else
                    MessageBox.Show("No Se Pudo Modificar La Nota De Credito");
            }
            BLL.EstudiantesBLL.Modificar(es);
            LimpiarTextBox();
        }

        /*
            NotasDeCredito Notas = LlenarClase();
            if (idnumericUpDown.Value == 0 || fechadateTimePicker.Text == string.Empty ||
                estudianteidnumericUpDown.Value == 0 || nombretextBox.Text == string.Empty ||
                montoasignaturasnumericUpDown.Value == 0 || pctnumericUpDown.Value == 0 ||
                montotextBox.Text == string.Empty)
                ValidarerrorProvider.SetError(guardarbutton, "No puede dejar nada vacio");
            else if (BLL.NotasDeCreditoBLL.Guardar(Notas))
                MessageBox.Show("Nota de Credito Guardada");

            LimpiarTextBox();       
        */

        private NotasDeCredito LlenarClase()
        {
            NotasDeCredito NC = new NotasDeCredito();
            int a, b;
            decimal MontoFinal;
            
            int.TryParse(idnumericUpDown.Text, out a);
            NC.notasID = a;
            NC.fecha = fechadateTimePicker.Value;
            int.TryParse(estudianteidnumericUpDown.Text, out b);
            NC.estudianteID = b;
            NC.montoAsignatura = montoasignaturasnumericUpDown.Value;
            NC.pctBeca = pctnumericUpDown.Value;
            MontoFinal = NC.montoAsignatura - (NC.montoAsignatura * (NC.pctBeca/100));
            NC.monto = MontoFinal;

            return NC;
        }

        private void LimpiarTextBox()
        {
            fechadateTimePicker.Value = DateTime.Now; ;
            estudianteidnumericUpDown.Value = 0;
            montoasignaturasnumericUpDown.Value = 0;
            pctnumericUpDown.Value = 0;
            montotextBox.Clear();
            idnumericUpDown.Value = 0;
            nombretextBox.Clear();
        }

        private void rNotasDeCredito_Load(object sender, EventArgs e)
        {

        }

        private void montoasignaturasnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (montoasignaturasnumericUpDown.Value != 0)
                montotextBox.Text = (montoasignaturasnumericUpDown.Value - (montoasignaturasnumericUpDown.Value * (pctnumericUpDown.Value / 100))).ToString();

        }

        private void pctnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (montoasignaturasnumericUpDown.Value != 0)
                montotextBox.Text = (montoasignaturasnumericUpDown.Value-(montoasignaturasnumericUpDown.Value * (pctnumericUpDown.Value / 100))).ToString();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            NotasDeCredito Nota = new NotasDeCredito();
            Estudiantes estudiantes = new Estudiantes();
            int.TryParse(idnumericUpDown.Text, out ID);

            Nota = BLL.NotasDeCreditoBLL.Buscar(ID);

            if (Nota != null)
            {
                MessageBox.Show("Nota de Credito Encontrada");
                fechadateTimePicker.Value = Nota.fecha;
                estudianteidnumericUpDown.Value = Convert.ToDecimal(Nota.estudianteID);
                montoasignaturasnumericUpDown.Value = Convert.ToDecimal(Nota.montoAsignatura);
                pctnumericUpDown.Value = Convert.ToDecimal(Nota.pctBeca);
                montotextBox.Text = Nota.monto.ToString();

                if (BLL.EstudiantesBLL.Buscar(Nota.estudianteID) != null)
                {
                    estudiantes = BLL.EstudiantesBLL.Buscar(Nota.estudianteID);
                    nombretextBox.Text = estudiantes.nombre;
                }
            }
            else
            {
                MessageBox.Show("Nota de Credito No encontada");
            }
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            NotasDeCredito Nota = new NotasDeCredito();

            int ID;
            int ID1;
            int.TryParse(idnumericUpDown.Text, out ID);
            int.TryParse(estudianteidnumericUpDown.Text, out ID1);
            Estudiantes es = BLL.EstudiantesBLL.Buscar(ID1);
            NotasDeCredito nc = BLL.NotasDeCreditoBLL.Buscar(ID);
            es.montoDescuento -= nc.monto;

            if (BLL.NotasDeCreditoBLL.Eliminar(ID))
                MessageBox.Show("Acaba de Eliminar Esta Nota de Credito");
            else
                MessageBox.Show("No Puede Eliminar Una Nota de Credito Que No Existe");
            BLL.EstudiantesBLL.Modificar(es);
            LimpiarTextBox();
        }

        private void buscarEbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(estudianteidnumericUpDown.Text, out ID);

            estudiante = BLL.EstudiantesBLL.Buscar(ID);

            if (estudiante != null)
            {
                MessageBox.Show("Estudiante Encontrado");
                nombretextBox.Text = estudiante.nombre;
            }
            else
            {
                MessageBox.Show("Estudiante No Encontrado");
            }
        }

        private void consultarbutton_Click(object sender, EventArgs e)
        {
            cNotasDeCredito cnc = new cNotasDeCredito();
            cnc.Show();
        }
    }
}
