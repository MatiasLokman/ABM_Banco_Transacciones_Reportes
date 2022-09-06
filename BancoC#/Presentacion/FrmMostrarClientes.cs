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
    public partial class FrmMostrarClientes : Form
    {
        public FrmMostrarClientes()
        {
            InitializeComponent();
        }

        

        private void FrmMostrarClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_113870DataSet1.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.db_113870DataSet1.Clientes);
            this.reportViewer1.RefreshReport();
        }
    }
}
