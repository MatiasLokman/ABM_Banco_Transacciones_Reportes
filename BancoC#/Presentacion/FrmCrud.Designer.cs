
namespace Banco
{
    partial class FrmCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtUltimoMovimiento = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblUltimoMovimiento = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboTiposCuenta = new System.Windows.Forms.ComboBox();
            this.pCrudCliente = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblCbucliente = new System.Windows.Forms.Label();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.lblAbm = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientesyCuentas = new System.Windows.Forms.DataGridView();
            this.lblClientesyCuentas = new System.Windows.Forms.Label();
            this.pCrudCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesyCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(273, 483);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 35);
            this.btnEditar.TabIndex = 113;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtUltimoMovimiento
            // 
            this.txtUltimoMovimiento.Location = new System.Drawing.Point(698, 87);
            this.txtUltimoMovimiento.Name = "txtUltimoMovimiento";
            this.txtUltimoMovimiento.Size = new System.Drawing.Size(155, 20);
            this.txtUltimoMovimiento.TabIndex = 51;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSaldo.Location = new System.Drawing.Point(648, 22);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 16);
            this.lblSaldo.TabIndex = 35;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(698, 20);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 20);
            this.txtSaldo.TabIndex = 36;
            // 
            // lblUltimoMovimiento
            // 
            this.lblUltimoMovimiento.AutoSize = true;
            this.lblUltimoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMovimiento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUltimoMovimiento.Location = new System.Drawing.Point(574, 91);
            this.lblUltimoMovimiento.Name = "lblUltimoMovimiento";
            this.lblUltimoMovimiento.Size = new System.Drawing.Size(118, 16);
            this.lblUltimoMovimiento.TabIndex = 47;
            this.lblUltimoMovimiento.Text = "Ultimo movimiento";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTipoCuenta.Location = new System.Drawing.Point(594, 54);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(98, 16);
            this.lblTipoCuenta.TabIndex = 48;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // cboTiposCuenta
            // 
            this.cboTiposCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposCuenta.FormattingEnabled = true;
            this.cboTiposCuenta.Location = new System.Drawing.Point(698, 53);
            this.cboTiposCuenta.Name = "cboTiposCuenta";
            this.cboTiposCuenta.Size = new System.Drawing.Size(155, 21);
            this.cboTiposCuenta.TabIndex = 50;
            // 
            // pCrudCliente
            // 
            this.pCrudCliente.BackColor = System.Drawing.SystemColors.WindowText;
            this.pCrudCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCrudCliente.Controls.Add(this.txtUltimoMovimiento);
            this.pCrudCliente.Controls.Add(this.lblSaldo);
            this.pCrudCliente.Controls.Add(this.txtNombre);
            this.pCrudCliente.Controls.Add(this.txtSaldo);
            this.pCrudCliente.Controls.Add(this.lblApellido);
            this.pCrudCliente.Controls.Add(this.lblUltimoMovimiento);
            this.pCrudCliente.Controls.Add(this.lblNombre);
            this.pCrudCliente.Controls.Add(this.lblTipoCuenta);
            this.pCrudCliente.Controls.Add(this.lblDni);
            this.pCrudCliente.Controls.Add(this.cboTiposCuenta);
            this.pCrudCliente.Controls.Add(this.txtApellido);
            this.pCrudCliente.Controls.Add(this.txtDni);
            this.pCrudCliente.Controls.Add(this.lblCbucliente);
            this.pCrudCliente.Controls.Add(this.txtCbu);
            this.pCrudCliente.Location = new System.Drawing.Point(12, 267);
            this.pCrudCliente.Name = "pCrudCliente";
            this.pCrudCliente.Size = new System.Drawing.Size(871, 169);
            this.pCrudCliente.TabIndex = 109;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.lblApellido.Location = new System.Drawing.Point(32, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 16);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Location = new System.Drawing.Point(33, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDni.Location = new System.Drawing.Point(59, 93);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 16);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(110, 92);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(155, 20);
            this.txtDni.TabIndex = 30;
            // 
            // lblCbucliente
            // 
            this.lblCbucliente.AutoSize = true;
            this.lblCbucliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbucliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCbucliente.Location = new System.Drawing.Point(54, 128);
            this.lblCbucliente.Name = "lblCbucliente";
            this.lblCbucliente.Size = new System.Drawing.Size(36, 16);
            this.lblCbucliente.TabIndex = 31;
            this.lblCbucliente.Text = "CBU";
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(110, 127);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(155, 20);
            this.txtCbu.TabIndex = 33;
            // 
            // lblAbm
            // 
            this.lblAbm.AutoSize = true;
            this.lblAbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbm.Location = new System.Drawing.Point(405, 239);
            this.lblAbm.Name = "lblAbm";
            this.lblAbm.Size = new System.Drawing.Size(58, 25);
            this.lblAbm.TabIndex = 105;
            this.lblAbm.Text = "ABM";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(431, 483);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(152, 35);
            this.btnActualizar.TabIndex = 104;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(431, 524);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 35);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(273, 442);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(152, 35);
            this.btnNuevo.TabIndex = 101;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 527);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 32);
            this.btnVolver.TabIndex = 100;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(782, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 35);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(431, 442);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 35);
            this.btnAgregar.TabIndex = 94;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientesyCuentas
            // 
            this.dgvClientesyCuentas.AllowUserToAddRows = false;
            this.dgvClientesyCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesyCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientesyCuentas.Location = new System.Drawing.Point(12, 37);
            this.dgvClientesyCuentas.Name = "dgvClientesyCuentas";
            this.dgvClientesyCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesyCuentas.Size = new System.Drawing.Size(871, 199);
            this.dgvClientesyCuentas.TabIndex = 93;
            this.dgvClientesyCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesyCuentas_CellClick);
            this.dgvClientesyCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesyCuentas_CellContentClick);
            // 
            // lblClientesyCuentas
            // 
            this.lblClientesyCuentas.AutoSize = true;
            this.lblClientesyCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesyCuentas.Location = new System.Drawing.Point(315, 9);
            this.lblClientesyCuentas.Name = "lblClientesyCuentas";
            this.lblClientesyCuentas.Size = new System.Drawing.Size(241, 25);
            this.lblClientesyCuentas.TabIndex = 115;
            this.lblClientesyCuentas.Text = "CLIENTES Y CUENTAS";
            // 
            // FrmCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 571);
            this.Controls.Add(this.lblClientesyCuentas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pCrudCliente);
            this.Controls.Add(this.lblAbm);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvClientesyCuentas);
            this.Name = "FrmCrud";
            this.Text = "ABM Banco";
            this.Load += new System.EventHandler(this.FrmCrud_Load);
            this.pCrudCliente.ResumeLayout(false);
            this.pCrudCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesyCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblUltimoMovimiento;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboTiposCuenta;
        private System.Windows.Forms.Panel pCrudCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblCbucliente;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Label lblAbm;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientesyCuentas;
        private System.Windows.Forms.Label lblClientesyCuentas;
        private System.Windows.Forms.TextBox txtUltimoMovimiento;
    }
}

