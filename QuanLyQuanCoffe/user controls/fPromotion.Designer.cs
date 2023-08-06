
namespace QuanLyQuanCoffe.user_controls
{
    partial class fPromotion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAddPromo = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelPromotion = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khuyến mại ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonAddPromo
            // 
            this.ButtonAddPromo.AutoRoundedCorners = true;
            this.ButtonAddPromo.BorderRadius = 24;
            this.ButtonAddPromo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddPromo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddPromo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddPromo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddPromo.FillColor = System.Drawing.Color.ForestGreen;
            this.ButtonAddPromo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPromo.ForeColor = System.Drawing.Color.White;
            this.ButtonAddPromo.Location = new System.Drawing.Point(67, 502);
            this.ButtonAddPromo.Name = "ButtonAddPromo";
            this.ButtonAddPromo.Size = new System.Drawing.Size(190, 50);
            this.ButtonAddPromo.TabIndex = 2;
            this.ButtonAddPromo.Text = "Thêm mã mới";
            this.ButtonAddPromo.Click += new System.EventHandler(this.ButtonAddPromo_Click);
            // 
            // flowLayoutPanelPromotion
            // 
            this.flowLayoutPanelPromotion.AutoScroll = true;
            this.flowLayoutPanelPromotion.Location = new System.Drawing.Point(23, 65);
            this.flowLayoutPanelPromotion.Name = "flowLayoutPanelPromotion";
            this.flowLayoutPanelPromotion.Size = new System.Drawing.Size(828, 416);
            this.flowLayoutPanelPromotion.TabIndex = 3;
            this.flowLayoutPanelPromotion.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPromotion_Paint);
            // 
            // fPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelPromotion);
            this.Controls.Add(this.ButtonAddPromo);
            this.Controls.Add(this.label1);
            this.Name = "fPromotion";
            this.Size = new System.Drawing.Size(881, 565);
            this.Load += new System.EventHandler(this.fPromotion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonAddPromo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPromotion;
    }
}
