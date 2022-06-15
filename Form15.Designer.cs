namespace Ильиных_Гостиница
{
    partial class Form15
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ДоговорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ИльиныхDataSet = new Ильиных_Гостиница.ИльиныхDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ДоговорTableAdapter = new Ильиных_Гостиница.ИльиныхDataSetTableAdapters.ДоговорTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ДоговорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ДоговорBindingSource
            // 
            this.ДоговорBindingSource.DataMember = "Договор";
            this.ДоговорBindingSource.DataSource = this.ИльиныхDataSet;
            // 
            // ИльиныхDataSet
            // 
            this.ИльиныхDataSet.DataSetName = "ИльиныхDataSet";
            this.ИльиныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.ДоговорBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ильиных_Гостиница.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // ДоговорTableAdapter
            // 
            this.ДоговорTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(706, 411);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "<< Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(880, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ДоговорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ДоговорBindingSource;
        private ИльиныхDataSet ИльиныхDataSet;
        private ИльиныхDataSetTableAdapters.ДоговорTableAdapter ДоговорTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}