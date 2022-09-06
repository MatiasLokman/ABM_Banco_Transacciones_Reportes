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
    public partial class FrmDesactivados : Form
    {
        DBHelper oDB = new DBHelper();
        public FrmDesactivados()
        {
            InitializeComponent();
        }

        private void FrmDesactivados_Load(object sender, EventArgs e)
        {
            cargarGrilla("GrillaClientesCuentasDesactivadas", dgvClientesyCuentas);
            dgvClientesyCuentas.Enabled = false;
        }

        private void cargarGrilla(string nombreGrillaSP, DataGridView nombreDGV)
        {
            DataTable tabla = oDB.consultarDB(nombreGrillaSP);
            nombreDGV.DataSource = tabla;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea regresar?",
               "REGRESANDO",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void dgvClientesyCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int cbu = Convert.ToInt32(dgvClientesyCuentas.CurrentRow.Cells[3].Value.ToString());
                if (oDB.estadoDB("EstadoActivada", cbu))
                {
                    MessageBox.Show("El registro fue activado con éxito!");

                }
                else
                {
                    MessageBox.Show("El registro no pudo ser activado");
                }
                cargarGrilla("GrillaClientesCuentasDesactivadas", dgvClientesyCuentas);
                dgvClientesyCuentas.Columns.Remove("btnAcciones");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe clickear el boton activar de un registro de la grilla para poder activarlo ...");
    
            dgvClientesyCuentas.Enabled = true;


            DataGridViewButtonColumn AccionesBtn = new DataGridViewButtonColumn();

            AccionesBtn.HeaderText = "Acciones";
            AccionesBtn.Name = "btnAcciones";
            AccionesBtn.Text = "Activar";
            AccionesBtn.UseColumnTextForButtonValue = true;
            dgvClientesyCuentas.Columns.Add(AccionesBtn);
        }
    }
}
