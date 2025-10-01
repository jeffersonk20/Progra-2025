using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Academica objAlumnos= new Academica();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocente objDocente = new frmDocente();
            objDocente.MdiParent = this;
            objDocente.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria objMateria = new frmMateria();
            objMateria.MdiParent = this;
            objMateria.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objPeriodos = new frmPeriodos();
            objPeriodos.MdiParent = this;
            objPeriodos.Show(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
