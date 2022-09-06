using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmCrud : Form
    {
        DBHelper oDB = new DBHelper();

        public FrmCrud()
        {
            InitializeComponent();
        }

        private void FrmCrud_Load(object sender, EventArgs e)
        {
            cargarCombo("ComboTiposCuenta", cboTiposCuenta, "nombre", "tipoCuenta");
            inicializarForm();
        }

        private void inicializarForm()
        {
            limpiar();
            cargarGrilla("GrillaClientesCuentas", dgvClientesyCuentas);
            habilitar(false);
            btnCancelar.Enabled = false;
            btnVolver.Enabled = true;

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;

            dgvClientesyCuentas.Enabled = false;
            btnVolver.Focus();
        }

        private void habilitar(bool x)
        {
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            txtDni.Enabled = x;
            txtCbu.Enabled = x;
            txtSaldo.Enabled = x;
            cboTiposCuenta.Enabled = x;
            txtUltimoMovimiento.Enabled = x;

            btnNuevo.Enabled = x;
            btnAgregar.Enabled = x;
            btnEditar.Enabled = x;
            btnActualizar.Enabled = x;
            btnEliminar.Enabled = x;
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtCbu.Text = "";
            txtSaldo.Text = "";
            cboTiposCuenta.SelectedIndex = -1;
            txtUltimoMovimiento.Text = "";
        }

        private void cargarCombo(string nombreComboSP, ComboBox nombreCombo, string displayMember, string valueMember)
        {
            DataTable tabla = oDB.consultarDB(nombreComboSP);
            nombreCombo.DataSource = tabla;
            nombreCombo.DisplayMember = displayMember;
            nombreCombo.ValueMember = valueMember;
        }

        private void cargarGrilla(string nombreGrillaSP, DataGridView nombreDGV)
        {
            DataTable tabla = oDB.consultarDB(nombreGrillaSP);
            nombreDGV.DataSource = tabla;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvClientesyCuentas.Columns.Remove("btnAcciones");
            inicializarForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            txtNombre.Focus();
            habilitar(true);
            btnCancelar.Enabled = true;
            btnVolver.Enabled = false;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            btnAgregar.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int dni = Convert.ToInt32(txtDni.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int cbu = Convert.ToInt32(txtCbu.Text);
                int saldo = Convert.ToInt32(txtSaldo.Text);
                int tipoCuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                int ultimoMovimiento = Convert.ToInt32(txtUltimoMovimiento.Text);

                if (!existeDni())
                {
                    if (!existeCbu())
                    {
                        if (oDB.agregarDB(dni, nombre, apellido, cbu, saldo, tipoCuenta, ultimoMovimiento))
                        {
                            MessageBox.Show("Registro agregado con éxito!");
                            inicializarForm();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pudo ser agregado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un valor no repetido para el CBU");
                        txtCbu.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor no repetido para el DNI");
                    txtDni.Focus();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar un registro de la grilla para poder actualizarlo o eliminarlo ...");
            limpiar();
            dgvClientesyCuentas.Enabled = true;
            txtNombre.Focus();

            habilitar(true);
            btnCancelar.Enabled = true;
            btnVolver.Enabled = false;

            btnNuevo.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;

            txtDni.Enabled = false;
            txtCbu.Enabled = false;

            cargarGrilla("GrillaClientesCuentas", dgvClientesyCuentas);
            DataGridViewButtonColumn AccionesBtn = new DataGridViewButtonColumn();

            AccionesBtn.HeaderText = "Acciones";
            AccionesBtn.Name = "btnAcciones";
            AccionesBtn.Text = "Desactivar";
            AccionesBtn.UseColumnTextForButtonValue = true;
            dgvClientesyCuentas.Columns.Add(AccionesBtn);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (existeCbu())
                {
                    int dni = Convert.ToInt32(txtDni.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int cbu = Convert.ToInt32(txtCbu.Text);
                    int saldo = Convert.ToInt32(txtSaldo.Text);
                    int tipocuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                    int ultimomovimiento = Convert.ToInt32(txtUltimoMovimiento.Text);

                    if (oDB.actualizarDB(dni, nombre, apellido, cbu, saldo, tipocuenta, ultimomovimiento))
                    {
                        MessageBox.Show("Registro actualizado con éxito!");
                        inicializarForm();
                    } else
                    {
                        MessageBox.Show("El registro no pudo ser actualizado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un CBU existente");
                }
                dgvClientesyCuentas.Columns.Remove("btnAcciones");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int dni = Convert.ToInt32(txtDni.Text);
                int cbu = Convert.ToInt32(txtCbu.Text);

                if (MessageBox.Show("Seguro que desea eliminar este registro?",
                       "Eliminando registro",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if(oDB.eliminarDB(dni, cbu))
                    {
                        MessageBox.Show("Registro eliminado con éxito!");
                        inicializarForm();
                    } else
                    {
                        MessageBox.Show("El registro no pudo ser eliminado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la grilla para poder eliminarlo");
            }
        }

        private void dgvClientesyCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientesyCuentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtNombre.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtApellido.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtDni.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtCbu.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtSaldo.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                cboTiposCuenta.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtUltimoMovimiento.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre ...");
                txtNombre.Focus();
                valido = false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido ...");
                txtApellido.Focus();
                valido = false;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI ...");
                txtDni.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDni.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el DNI");
                    txtDni.Focus();
                    return false;
                }
            }
            if (txtCbu.Text == "")
            {
                MessageBox.Show("Debe ingresar un CBU ...");
                txtCbu.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCbu.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el CBU");
                    txtCbu.Focus();
                    return false;
                }
            }
            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Debe ingresar un saldo ...");
                txtSaldo.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtSaldo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el saldo");
                    txtSaldo.Focus();
                    return false;
                }
            }
            if (cboTiposCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta ...");
                cboTiposCuenta.Focus();
                valido = false;
            }
            if (txtUltimoMovimiento.Text == "")
            {
                MessageBox.Show("Debe ingresar un ultimo movimiento ...");
                txtUltimoMovimiento.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtUltimoMovimiento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el ultimo movimiento");
                    txtUltimoMovimiento.Focus();
                    return false;
                }
            }
            return valido;
        }

        private bool existeDni()
        {
            for (int i = 0; i < dgvClientesyCuentas.Rows.Count; i++)
            {
                if (txtDni.Text == dgvClientesyCuentas.Rows[i].Cells[0].Value.ToString())
                    return true;
            }
            return false;
        }

        private bool existeCbu()
        {
            for (int i = 0; i < dgvClientesyCuentas.Rows.Count; i++)
            {
                if (txtCbu.Text == dgvClientesyCuentas.Rows[i].Cells[3].Value.ToString())
                    return true;
            }
            return false;
        }

        private void dgvClientesyCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int cbu = Convert.ToInt32(dgvClientesyCuentas.CurrentRow.Cells[3].Value.ToString());
                if (oDB.estadoDB("EstadoDesactivada",cbu))
                {
                    MessageBox.Show("El registro fue desactivado con éxito!");


                } else
                {
                    MessageBox.Show("El registro no pudo ser desactivado");
                }
                cargarGrilla("GrillaClientesCuentas", dgvClientesyCuentas);
                dgvClientesyCuentas.Columns.Remove("btnAcciones");
            }
            inicializarForm();
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
    }
}