using PuntosExtra.Consultas;
using PuntosExtra.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntosExtra
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes re = new rEstudiantes();
            re.Show();
        }

        private void notasDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rNotasDeCredito rnc = new rNotasDeCredito();
            rnc.Show();
        }

        private void estudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEstudiantes ce = new cEstudiantes();
            ce.Show();
        }

        private void notasDeCreditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cNotasDeCredito cnc = new cNotasDeCredito();
            cnc.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
