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
            decimal monto;
            Expression<Func<NotasDeCredito, bool>> all = x => true;
            
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                ID = int.Parse(CriteriotextBox.Text);
                lista = BLL.NotasDeCreditoBLL.GetList(t => t.notasID == ID);
                all = x => x.notasID == ID;
            }

            if (FiltrarcomboBox.SelectedIndex == 1)
            {
               monto = decimal.Parse(CriteriotextBox.Text);
               lista = BLL.NotasDeCreditoBLL.GetList(nc => nc.montoAsignatura == monto);
               all = x => x.montoAsignatura == monto;
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
            ReporteDeNotasDeCredito rnc = new ReporteDeNotasDeCredito(lista);
            rnc.Show();
        }
    }
}
