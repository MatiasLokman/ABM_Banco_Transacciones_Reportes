using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Presentacion
{
    public partial class FrmMostrarCuentas : Form
    {
        public FrmMostrarCuentas()
        {
            InitializeComponent();
        }

        public int estado { get; set; }

        private void FrmMostrarCuentas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            estado = Convert.ToInt32(txtGenerar.Text);
            // TODO: This line of code loads data into the 'db_113870DataSet2.MostrarCuentas' table. You can move, or remove it, as needed.
            this.mostrarCuentasTableAdapter.Fill(this.db_113870DataSet2.MostrarCuentas, estado);
            this.reportViewer1.RefreshReport();
        }
    }
}
