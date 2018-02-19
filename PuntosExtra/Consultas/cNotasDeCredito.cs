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
    public partial class cNotasDeCredito : Form
    {
        List<NotasDeCredito> lista = new List<NotasDeCredito>();
        public cNotasDeCredito()
        {
            InitializeComponent();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Expression<Func<NotasDeCredito, bool>> all = x => true;
            
            int.TryParse(CriteriotextBox.Text, out ID);
            
            if (FiltrarcomboBox.SelectedIndex == 0)
                lista = BLL.NotasDeCreditoBLL.GetList(t => t.notasID == ID);
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                int montoa = 0;
                int.TryParse(CriteriotextBox.Text, out montoa);

               lista = BLL.NotasDeCreditoBLL.GetList(nc => nc.montoAsignatura == montoa);
            }
            if(FiltrarcomboBox.Text == string.Empty || CriteriotextBox.Text == string.Empty)
                lista = BLL.NotasDeCreditoBLL.GetList(all);

            NotasDeCreditodataGridView.DataSource = lista;
        }

        private void cNotasDeCredito_Load(object sender, EventArgs e)
        {

        }

        private void imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporteDeNotasDeEstudiantes rne = new ReporteDeNotasDeEstudiantes(lista);
            rne.Show();
        }
    }
}
