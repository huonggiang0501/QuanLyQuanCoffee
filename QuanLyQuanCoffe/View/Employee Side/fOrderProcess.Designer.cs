
namespace QuanLyQuanCoffe.View.Employee_Side
{
    partial class fOrderProcess
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
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonClose = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPrint = new Guna.UI2.WinForms.Guna2Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(QuanLyQuanCoffe.Models.Order);
            this.OrderBindingSource.CurrentChanged += new System.EventHandler(this.OrderBindingSource_CurrentChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 109);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successful Transaction";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BorderColor = System.Drawing.Color.Silver;
            this.ButtonClose.BorderThickness = 1;
            this.ButtonClose.FillColor = System.Drawing.Color.White;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonClose.Location = new System.Drawing.Point(253, 613);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(171, 45);
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.Text = "Close Window";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.ButtonPrint.Location = new System.Drawing.Point(18, 613);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(171, 45);
            this.ButtonPrint.TabIndex = 15;
            this.ButtonPrint.Text = "Print Receipt";
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCoffe.View.Employee Side.Report1.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(3, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(444, 491);
            this.reportViewer1.TabIndex = 16;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // fOrderProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 668);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPrint);
            this.Name = "fOrderProcess";
            this.Text = "fOrderProcess";
            this.Load += new System.EventHandler(this.fOrderProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonClose;
        private Guna.UI2.WinForms.Guna2Button ButtonPrint;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrderBindingSource;
    }
}