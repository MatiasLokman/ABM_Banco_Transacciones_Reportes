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
    public partial class FrmMostrarCliente : Form
    {
        public FrmMostrarCliente()
        {
            InitializeComponent();
        }
        
        public string Buscar { get; set; }

        private void FrmMostrarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar = txtBuscar.Text;
            // TODO: This line of code loads data into the 'db_113870DataSet.ReporteClientes' table. You can move, or remove it, as needed.
            this.reporteClientesTableAdapter.Fill(this.db_113870DataSet.ReporteClientes, Buscar);

            this.reportViewer1.RefreshReport();
        }
    }
}
