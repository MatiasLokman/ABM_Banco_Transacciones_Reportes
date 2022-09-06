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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea abandonar la aplicación?",
               "SALIENDO",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrud crudFrm = new FrmCrud();
            crudFrm.ShowDialog();
        }

        private void registrosDesabilitadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDesactivados desactivadosFrm = new FrmDesactivados();
            desactivadosFrm.ShowDialog();
        }

        private void verTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void unoSoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarCliente reporte = new FrmMostrarCliente();
            reporte.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarClientes mostrarClientes = new FrmMostrarClientes();
            mostrarClientes.ShowDialog();
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarCuentas mostrarCuentas = new FrmMostrarCuentas();
            mostrarCuentas.ShowDialog();
        }
    }
}



    
    
