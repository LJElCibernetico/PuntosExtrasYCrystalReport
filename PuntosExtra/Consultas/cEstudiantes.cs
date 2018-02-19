using PuntosExtra.Entidades;
using PuntosExtra.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace PuntosExtra.Consultas
{
    public partial class cEstudiantes : Form
    {
        List<Estudiantes> lista = new List<Estudiantes>();
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Estudiantes, bool>> all = x => true;
            String a = CriteriotextBox.Text;
            int ID;
            int.TryParse(CriteriotextBox.Text, out ID);

            if (FiltrarcomboBox.SelectedIndex == 0)
               lista = BLL.EstudiantesBLL.GetList(t => t.nombre.Contains(a));
            if (FiltrarcomboBox.SelectedIndex == 1)
                lista= BLL.EstudiantesBLL.GetList(t => t.estudianteID == ID);
            if(FiltrarcomboBox.Text == string.Empty || CriteriotextBox.Text == string.Empty)
                lista = BLL.EstudiantesBLL.GetList(all);

            EstudiantedataGridView.DataSource = lista;
        }

        private void imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporteEstudiantes re = new ReporteEstudiantes(lista);
            re.Show();
        }
    }
}
