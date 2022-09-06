
namespace Banco.Presentacion
{
    partial class FrmMostrarCliente
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_113870DataSet = new Banco.db_113870DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteClientesTableAdapter = new Banco.db_113870DataSetTableAdapters.ReporteClientesTableAdapter();
            this.lblClientesyCuentasDesactivadas = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reporteClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteClientesBindingSource
            // 
            this.reporteClientesBindingSource.DataMember = "ReporteClientes";
            this.reporteClientesBindingSource.DataSource = this.db_113870DataSet;
            // 
            // db_113870DataSet
            // 
            this.db_113870DataSet.DataSetName = "db_113870DataSet";
            this.db_113870DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.reporteClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Banco.Presentacion.ReporteCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(713, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteClientesTableAdapter
            // 
            this.reporteClientesTableAdapter.ClearBeforeFill = true;
            // 
            // lblClientesyCuentasDesactivadas
            // 
            this.lblClientesyCuentasDesactivadas.AutoSize = true;
            this.lblClientesyCuentasDesactivadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesyCuentasDesactivadas.Location = new System.Drawing.Point(12, 9);
            this.lblClientesyCuentasDesactivadas.Name = "lblClientesyCuentasDesactivadas";
            this.lblClientesyCuentasDesactivadas.Size = new System.Drawing.Size(211, 25);
            this.lblClientesyCuentasDesactivadas.TabIndex = 121;
            this.lblClientesyCuentasDesactivadas.Text = "MOSTRAR CLIENTE";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(124, 46);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 20);
            this.txtBuscar.TabIndex = 120;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(17, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 20);
            this.btnBuscar.TabIndex = 119;
            this.btnBuscar.Text = "Buscar cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmMostrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.lblClientesyCuentasDesactivadas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarCliente";
            this.Text = "FrmMostrarCliente";
            this.Load += new System.EventHandler(this.FrmMostrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteClientesBindingSource;
        private db_113870DataSet db_113870DataSet;
        private db_113870DataSetTableAdapters.ReporteClientesTableAdapter reporteClientesTableAdapter;
        private System.Windows.Forms.Label lblClientesyCuentasDesactivadas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}