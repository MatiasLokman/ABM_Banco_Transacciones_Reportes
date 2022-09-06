
namespace Banco.Presentacion
{
    partial class FrmMostrarCuentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mostrarCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_113870DataSet2 = new Banco.db_113870DataSet2();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtGenerar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mostrarCuentasTableAdapter = new Banco.db_113870DataSet2TableAdapters.MostrarCuentasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_113870DataSet21 = new Banco.db_113870DataSet2();
            this.mostrarCuentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblClientesyCuentasDesactivadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarCuentasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarCuentasBindingSource
            // 
            this.mostrarCuentasBindingSource.DataMember = "MostrarCuentas";
            this.mostrarCuentasBindingSource.DataSource = this.db_113870DataSet2;
            // 
            // db_113870DataSet2
            // 
            this.db_113870DataSet2.DataSetName = "db_113870DataSet2";
            this.db_113870DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(17, 46);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 20);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Buscar cuenta";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtGenerar
            // 
            this.txtGenerar.Location = new System.Drawing.Point(123, 46);
            this.txtGenerar.Name = "txtGenerar";
            this.txtGenerar.Size = new System.Drawing.Size(104, 20);
            this.txtGenerar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0 - Desactivadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1 - Activadas";
            // 
            // mostrarCuentasTableAdapter
            // 
            this.mostrarCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.mostrarCuentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Banco.Presentacion.ReporteCuentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 299);
            this.reportViewer1.TabIndex = 5;
            // 
            // db_113870DataSet21
            // 
            this.db_113870DataSet21.DataSetName = "db_113870DataSet2";
            this.db_113870DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarCuentasBindingSource1
            // 
            this.mostrarCuentasBindingSource1.DataMember = "MostrarCuentas";
            this.mostrarCuentasBindingSource1.DataSource = this.db_113870DataSet21;
            // 
            // lblClientesyCuentasDesactivadas
            // 
            this.lblClientesyCuentasDesactivadas.AutoSize = true;
            this.lblClientesyCuentasDesactivadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesyCuentasDesactivadas.Location = new System.Drawing.Point(12, 9);
            this.lblClientesyCuentasDesactivadas.Name = "lblClientesyCuentasDesactivadas";
            this.lblClientesyCuentasDesactivadas.Size = new System.Drawing.Size(223, 25);
            this.lblClientesyCuentasDesactivadas.TabIndex = 117;
            this.lblClientesyCuentasDesactivadas.Text = "MOSTRAR CUENTAS";
            // 
            // FrmMostrarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 403);
            this.Controls.Add(this.lblClientesyCuentasDesactivadas);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenerar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "FrmMostrarCuentas";
            this.Text = "FrmMostrarCuentas";
            this.Load += new System.EventHandler(this.FrmMostrarCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_113870DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarCuentasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource mostrarCuentasBindingSource;
        private Banco.db_113870DataSet2 db_113870DataSet2;
        private Banco.db_113870DataSet2TableAdapters.MostrarCuentasTableAdapter mostrarCuentasTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private db_113870DataSet2 db_113870DataSet21;
        private System.Windows.Forms.BindingSource mostrarCuentasBindingSource1;
        private System.Windows.Forms.Label lblClientesyCuentasDesactivadas;
    }
}