namespace Ильиных_Гостиница
{
    partial class Form14
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
            this.button2 = new System.Windows.Forms.Button();
            this.ИльиныхDataSet = new Ильиных_Гостиница.ИльиныхDataSet();
            this.Услуги_клиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Услуги_клиентаTableAdapter = new Ильиных_Гостиница.ИльиныхDataSetTableAdapters.Услуги_клиентаTableAdapter();
            this.ИльиныхDataSet1 = new Ильиных_Гостиница.ИльиныхDataSet1();
            this.ИльиныхDataSet2 = new Ильиных_Гостиница.ИльиныхDataSet2();
            this.ИльиныхDataSet3 = new Ильиных_Гостиница.ИльиныхDataSet3();
            this.УслугиклиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.УслугиклиентаTableAdapter = new Ильиных_Гостиница.ИльиныхDataSet3TableAdapters.УслугиклиентаTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Услуги_клиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.УслугиклиентаBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.button2.TabIndex = 4;
            this.button2.Text = "<< Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ИльиныхDataSet
            // 
            this.ИльиныхDataSet.DataSetName = "ИльиныхDataSet";
            this.ИльиныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Услуги_клиентаBindingSource
            // 
            this.Услуги_клиентаBindingSource.DataMember = "Услуги клиента";
            this.Услуги_клиентаBindingSource.DataSource = this.ИльиныхDataSet;
            // 
            // Услуги_клиентаTableAdapter
            // 
            this.Услуги_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // ИльиныхDataSet1
            // 
            this.ИльиныхDataSet1.DataSetName = "ИльиныхDataSet1";
            this.ИльиныхDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ИльиныхDataSet2
            // 
            this.ИльиныхDataSet2.DataSetName = "ИльиныхDataSet2";
            this.ИльиныхDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ИльиныхDataSet3
            // 
            this.ИльиныхDataSet3.DataSetName = "ИльиныхDataSet3";
            this.ИльиныхDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // УслугиклиентаBindingSource
            // 
            this.УслугиклиентаBindingSource.DataMember = "Услугиклиента";
            this.УслугиклиентаBindingSource.DataSource = this.ИльиныхDataSet3;
            // 
            // УслугиклиентаTableAdapter
            // 
            this.УслугиклиентаTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.УслугиклиентаBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ильиных_Гостиница.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(860, 394);
            this.reportViewer1.TabIndex = 5;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(880, 447);

            this.Controls.Add(this.button2);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Услуги_клиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ИльиныхDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.УслугиклиентаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource Услуги_клиентаBindingSource;
        private ИльиныхDataSet ИльиныхDataSet;
        private ИльиныхDataSetTableAdapters.Услуги_клиентаTableAdapter Услуги_клиентаTableAdapter;
        private ИльиныхDataSet1 ИльиныхDataSet1;
        private ИльиныхDataSet2 ИльиныхDataSet2;
        private System.Windows.Forms.BindingSource УслугиклиентаBindingSource;
        private ИльиныхDataSet3 ИльиныхDataSet3;
        private ИльиныхDataSet3TableAdapters.УслугиклиентаTableAdapter УслугиклиентаTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}