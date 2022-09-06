
namespace Banco.Presentacion
{
    partial class FrmDesactivados
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
            this.dgvClientesyCuentas = new System.Windows.Forms.DataGridView();
            this.lblClientesyCuentasDesactivadas = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesyCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesyCuentas
            // 
            this.dgvClientesyCuentas.AllowUserToAddRows = false;
            this.dgvClientesyCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesyCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientesyCuentas.Location = new System.Drawing.Point(12, 34);
            this.dgvClientesyCuentas.Name = "dgvClientesyCuentas";
            this.dgvClientesyCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesyCuentas.Size = new System.Drawing.Size(871, 314);
            this.dgvClientesyCuentas.TabIndex = 94;
            this.dgvClientesyCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesyCuentas_CellContentClick);
            // 
            // lblClientesyCuentasDesactivadas
            // 
            this.lblClientesyCuentasDesactivadas.AutoSize = true;
            this.lblClientesyCuentasDesactivadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesyCuentasDesactivadas.Location = new System.Drawing.Point(256, 6);
            this.lblClientesyCuentasDesactivadas.Name = "lblClientesyCuentasDesactivadas";
            this.lblClientesyCuentasDesactivadas.Size = new System.Drawing.Size(408, 25);
            this.lblClientesyCuentasDesactivadas.TabIndex = 116;
            this.lblClientesyCuentasDesactivadas.Text = "CLIENTES Y CUENTAS DESACTIVADAS";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 366);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 32);
            this.btnVolver.TabIndex = 117;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(731, 366);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 32);
            this.btnEditar.TabIndex = 118;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmDesactivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 410);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblClientesyCuentasDesactivadas);
            this.Controls.Add(this.dgvClientesyCuentas);
            this.Name = "FrmDesactivados";
            this.Text = "FrmDesactivados";
            this.Load += new System.EventHandler(this.FrmDesactivados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesyCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesyCuentas;
        private System.Windows.Forms.Label lblClientesyCuentasDesactivadas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEditar;
    }
}