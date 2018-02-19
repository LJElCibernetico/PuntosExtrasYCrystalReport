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
   
    public partial class ReporteEstudiantes : Form
    {
        List<Estudiantes> lista = new List<Estudiantes>();
        public ReporteEstudiantes(List<Estudiantes> listas )
        {
            lista = listas;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument r = new ReportDocument();
            r.Load("C:/Users/LJ/Desktop/Programacion/7. Aplicada 1/PuntosExtra/PuntosExtra/Reportes/EstudiantesCrystalReport.rpt");
            r.SetDataSource(lista);

            crystalReportViewer.ReportSource = r;
            crystalReportViewer.Refresh();
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
