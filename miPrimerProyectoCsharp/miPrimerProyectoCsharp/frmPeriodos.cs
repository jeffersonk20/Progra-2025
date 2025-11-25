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
    public partial class frmPeriodos : Form
    {
        public frmPeriodos()
        {
            InitializeComponent();
        }

        private void periodoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.periodoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_academicaDataSet1);

        }

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet1.periodo' Puede moverla o quitarla según sea necesario.
            this.periodoTableAdapter.Fill(this.db_academicaDataSet1.periodo);

        }
    }
}
