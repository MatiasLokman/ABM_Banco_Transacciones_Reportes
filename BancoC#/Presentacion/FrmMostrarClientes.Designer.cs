
namespace Banco.Presentacion
{
    partial class FrmMostrarClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_113870DataSet1 = new Banco.db_113870DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesTableAdapter = new Banco.db_113870DataSet1TableAdapters.ClientesTableAdapter();
            this.lblClientesyCuentasDesactivadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.db_113870DataSet1;
            // 
            // db_113870DataSet1
            // 
            this.db_113870DataSet1.DataSetName = "db_113870DataSet1";
            this.db_113870DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.clientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Banco.Presentacion.ReporteClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(461, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // lblClientesyCuentasDesactivadas
            // 
            this.lblClientesyCuentasDesactivadas.AutoSize = true;
            this.lblClientesyCuentasDesactivadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesyCuentasDesactivadas.Location = new System.Drawing.Point(19, 34);
            this.lblClientesyCuentasDesactivadas.Name = "lblClientesyCuentasDesactivadas";
            this.lblClientesyCuentasDesactivadas.Size = new System.Drawing.Size(114, 25);
            this.lblClientesyCuentasDesactivadas.TabIndex = 122;
            this.lblClientesyCuentasDesactivadas.Text = "CLIENTES";
            // 
            // FrmMostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 404);
            this.Controls.Add(this.lblClientesyCuentasDesactivadas);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMostrarClientes";
            this.Text = "FrmMostrarClientes";
            this.Load += new System.EventHandler(this.FrmMostrarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_113870DataSet1 db_113870DataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private db_113870DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label lblClientesyCuentasDesactivadas;
    }
}