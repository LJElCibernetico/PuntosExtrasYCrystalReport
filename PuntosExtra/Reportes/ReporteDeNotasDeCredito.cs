using CrystalDecisions.CrystalReports.Engine;
using PuntosExtra.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntosExtra.Reportes
{
    public partial class ReporteDeNotasDeCredito : Form
    {
        List<NotasDeCredito> lista = new List<NotasDeCredito>();
        public ReporteDeNotasDeCredito(List<NotasDeCredito> listas)
        {
            lista = listas;
            InitializeComponent();
        }

        private void ReporteDeNotasDeEstudiantes_Load(object sender, EventArgs e)
        {
            ReportDocument r = new ReportDocument();
            r.Load("C:/Users/LJ/Desktop/Programacion/7. Aplicada 1/PuntosExtra/PuntosExtra/Reportes/NotasDeCreditoCrystalReport.rpt");
            r.SetDataSource(lista);

            crystalReportViewer1.ReportSource = r;
            crystalReportViewer1.Refresh();
        }
    }
}
