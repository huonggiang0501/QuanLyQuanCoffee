
namespace QuanLyQuanCoffe.user_controls
{
    partial class PromotionItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromotionItem));
            this.itemPromoName = new System.Windows.Forms.Label();
            this.itemPromoValidate = new System.Windows.Forms.Label();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // itemPromoName
            // 
            this.itemPromoName.AutoSize = true;
            this.itemPromoName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPromoName.Location = new System.Drawing.Point(40, 23);
            this.itemPromoName.Name = "itemPromoName";
            this.itemPromoName.Size = new System.Drawing.Size(79, 22);
            this.itemPromoName.TabIndex = 15;
            this.itemPromoName.Text = "Tên mã";
            this.itemPromoName.Click += new System.EventHandler(this.itemPromoName_Click);
            // 
            // itemPromoValidate
            // 
            this.itemPromoValidate.AutoSize = true;
            this.itemPromoValidate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPromoValidate.ForeColor = System.Drawing.Color.Gray;
            this.itemPromoValidate.Location = new System.Drawing.Point(45, 56);
            this.itemPromoValidate.Name = "itemPromoValidate";
            this.itemPromoValidate.Size = new System.Drawing.Size(62, 20);
            this.itemPromoValidate.TabIndex = 19;
            this.itemPromoValidate.Text = "Thời hạn";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.Image")));
            this.ButtonUpdate.ImageOffset = new System.Drawing.Point(1, 0);
            this.ButtonUpdate.ImageSize = new System.Drawing.Size(15, 15);
            this.ButtonUpdate.Location = new System.Drawing.Point(468, 33);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonUpdate.Size = new System.Drawing.Size(30, 30);
            this.ButtonUpdate.TabIndex = 21;
            this.ButtonUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonRemove.Animated = true;
            this.ButtonRemove.AutoRoundedCorners = true;
            this.ButtonRemove.BorderRadius = 14;
            this.ButtonRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRemove.ForeColor = System.Drawing.Color.White;
            this.ButtonRemove.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRemove.Image")));
            this.ButtonRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonRemove.ImageSize = new System.Drawing.Size(12, 12);
            this.ButtonRemove.Location = new System.Drawing.Point(527, 33);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(30, 30);
            this.ButtonRemove.TabIndex = 20;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // PromotionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.itemPromoValidate);
            this.Controls.Add(this.itemPromoName);
            this.Name = "PromotionItem";
            this.Size = new System.Drawing.Size(597, 95);
            this.Load += new System.EventHandler(this.PromotionItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemPromoName;
        private System.Windows.Forms.Label itemPromoValidate;
        public Guna.UI2.WinForms.Guna2CircleButton ButtonUpdate;
        public Guna.UI2.WinForms.Guna2Button ButtonRemove;
    }
}
